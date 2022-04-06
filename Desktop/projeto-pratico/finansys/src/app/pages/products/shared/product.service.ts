import { Injectable, Injector } from '@angular/core';
import { Product } from './product.model';
import { BaseResourceService } from 'src/app/shared/services/base-resource.service';
import { Observable } from 'rxjs';
import { catchError, flatMap } from 'rxjs/operators';
import { CategoryService } from '../../categories/shared/category.service';

@Injectable({
  providedIn: 'root'
})
export class ProductService extends BaseResourceService<Product> {

  constructor(protected injector: Injector) {
    super("api/products", injector, Product.fromJson);
   }

  //  create(product: Product): Observable<Product> {
  //   return this.setCategoryAndSendToServer(product, super.create.bind(this));
  // }

  // update(product: Product): Observable<Product> {
  //   return this.setCategoryAndSendToServer(product, super.update.bind(this));
  // }

  // private setCategoryAndSendToServer(product: Product, sendFn: any): Observable<Product>{
  //   return this.categoryService.getById(product.categoryId).pipe(
  //     flatMap(category => {
  //       product.category = category;
  //       return sendFn(product)
  //     }),
  //     catchError(this.handleError)
  //     );
  //   }


}
