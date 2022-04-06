import { NgModule } from '@angular/core';
import { SharedModule } from '../../shared/shared.module';
import { CommonModule } from '@angular/common';

import { SalesRoutingModule } from './sales-routing.module';

import { CalendarModule } from 'primeng/calendar';
import { IMaskModule } from 'angular-imask';

import { SaleListComponent } from './sale-list/sale-list.component';
import { SaleFormComponent} from './sale-form/sale-form.component';
@NgModule({
  declarations: [SaleListComponent, SaleFormComponent],
  imports: [
    CommonModule,
    SalesRoutingModule,
    CalendarModule,
    IMaskModule,
    SharedModule
  ]
})
export class SalesModule { }
