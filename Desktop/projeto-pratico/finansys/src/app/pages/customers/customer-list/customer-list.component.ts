import { Component } from '@angular/core';

import { Customer } from "../shared/customer.model";
import { CustomerService } from '../shared/customer.service';

import { BaserResourceListComponent } from '../../../shared/components/base-resource-list/base-resource-list.component';
@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
  styleUrls: ['./customer-list.component.css']
})
export class CustomerListComponent extends BaserResourceListComponent<Customer> {

  constructor(private customerService: CustomerService) {
    super(customerService)
  }

}
