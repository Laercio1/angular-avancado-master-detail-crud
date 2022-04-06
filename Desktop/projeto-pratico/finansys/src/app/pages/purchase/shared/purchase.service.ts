import { Injectable, Injector } from '@angular/core';
import { Purchase } from './purchase.model';
import { BaseResourceService } from 'src/app/shared/services/base-resource.service';
import { Observable } from 'rxjs';
import { catchError, flatMap, map } from 'rxjs/operators';
import { ProductService } from '../../products/shared/product.service';
import * as moment from 'moment';
import { CategoryService } from '../../categories/shared/category.service';

@Injectable({
  providedIn: 'root'
})
export class PurchaseService extends BaseResourceService<Purchase> {

  constructor(protected injector: Injector, private productService: ProductService, private categoryService: CategoryService) {
    super("api/purchase", injector, Purchase.fromJson);
   }

   create(purchase: Purchase): Observable<Purchase> {
    return this.setProductAndSendToServer(purchase, super.create.bind(this));
  }

  update(purchase: Purchase): Observable<Purchase> {
    return this.setProductAndSendToServer(purchase, super.update.bind(this));
  }

  createCategory(purchase: Purchase): Observable<Purchase> {
    return this.setCategoryAndSendToServer(purchase, super.create.bind(this));
  }

  updateCategory(purchase: Purchase): Observable<Purchase> {
    return this.setCategoryAndSendToServer(purchase, super.update.bind(this));
  }

  getByMonthAndYear(month: number, year: number): Observable<Purchase[]> {
    return this.getAll().pipe(
      map(purchase => this.filterByMonthAndYear(purchase, month, year))
    )
  }

  private setProductAndSendToServer(purchase: Purchase, sendFn: any): Observable<Purchase>{
    return this.productService.getById(purchase.productId).pipe(
      flatMap(product => {
        purchase.product = product;
        return sendFn(purchase)
      }),
      catchError(this.handleError)
      );
    }

    private setCategoryAndSendToServer(purchase: Purchase, sendFn: any): Observable<Purchase>{
    return this.categoryService.getById(purchase.categoryId).pipe(
      flatMap(category => {
        purchase.category = category;
        return sendFn(purchase)
      }),
      catchError(this.handleError)
      );
    }

    private filterByMonthAndYear(purchases: Purchase[], month: number, year: number) {
      return purchases.filter(purchase => {
        const entryDate = moment(purchase.date, 'DD/MM/YYYY');
        const monthMatches = entryDate.month() + 1 == month;
        const yearMatches = entryDate.year() == year;

        if(monthMatches && yearMatches) return purchase;
      })
    }


}
