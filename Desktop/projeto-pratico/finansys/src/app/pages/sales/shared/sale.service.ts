import { Injectable, Injector } from '@angular/core';
import { Sale } from './sale.model';
import { BaseResourceService } from 'src/app/shared/services/base-resource.service';
import { Observable } from 'rxjs';
import { catchError, flatMap, map } from 'rxjs/operators';
import { element } from 'protractor';
import * as moment from 'moment';
import { ProductService } from '../../products/shared/product.service';
import { CustomerService } from '../../customers/shared/customer.service';

@Injectable({
  providedIn: 'root'
})
export class SaleService extends BaseResourceService<Sale> {

  constructor(protected injector: Injector, private productService: ProductService, private customerService: CustomerService) {
    super("api/sales", injector, Sale.fromJson);
  }

  create(sale: Sale): Observable<Sale> {
    return this.setProductAndSendToServer(sale, super.create.bind(this));
  }

  createCustomer(sale: Sale): Observable<Sale> {
    return this.setCustomerAndSendToServer(sale, super.create.bind(this));
  }

  update(sale: Sale): Observable<Sale> {
    return this.setProductAndSendToServer(sale, super.update.bind(this));
  }

  updateCustomer(sale: Sale): Observable<Sale> {
    return this.setCustomerAndSendToServer(sale, super.update.bind(this));
  }

  getByMonthAndYear(month: number, year: number): Observable<Sale[]> {
    return this.getAll().pipe(
      map(entries => this.filterByMonthAndYear(entries, month, year))
    )
  }

  private setProductAndSendToServer(sale: Sale, sendFn: any): Observable<Sale>{
    return this.productService.getById(sale.productId).pipe(
      flatMap(product => {
        sale.product = product;
        return sendFn(sale)
      }),
      catchError(this.handleError)
      );
    }

    private setCustomerAndSendToServer(sale: Sale, sendFn: any): Observable<Sale>{
      return this.customerService.getById(sale.customerId).pipe(
        flatMap(customer => {
          sale.customer = customer;
          return sendFn(sale)
        }),
        catchError(this.handleError)
        );
      }

    private filterByMonthAndYear(entries: Sale[], month: number, year: number) {
      return entries.filter(sale => {
        const saleDate = moment(sale.date, 'DD/MM/YYYY');
        const monthMatches = saleDate.month() + 1 == month;
        const yearMatches = saleDate.year() == year;

        if(monthMatches && yearMatches) return sale;
      })
    }

  }
