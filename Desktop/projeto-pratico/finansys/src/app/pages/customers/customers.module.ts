import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CustomersRoutingModule } from './customers-routing.module';
import { CustomerListComponent } from './customer-list/customer-list.component';
import { CustomerFormComponent } from './customer-form/customer-form.component';
import { CalendarModule } from 'primeng/calendar';
import { IMaskModule } from 'angular-imask';
import { SharedModule } from 'src/app/shared/shared.module';

@NgModule({
  declarations: [CustomerListComponent, CustomerFormComponent],
  imports: [
    CommonModule,
    CustomersRoutingModule,
    CalendarModule,
    IMaskModule,
    SharedModule
  ]
})
export class CustomersModule { }
