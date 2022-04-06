import { Injectable, Injector } from '@angular/core';
import { Customer } from './customer.model';
import { BaseResourceService } from 'src/app/shared/services/base-resource.service';

@Injectable({
  providedIn: 'root'
})
export class CustomerService extends BaseResourceService<Customer> {

  constructor(protected injector: Injector) {
    super("api/customers", injector, Customer.fromJson);
   }


}
