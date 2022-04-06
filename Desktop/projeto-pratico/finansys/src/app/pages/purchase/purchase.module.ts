import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PurchasesRoutingModule } from './purchase-routing.module';
import { PurchaseFormComponent } from "./purchase-form/purchase-form.component";
import { SharedModule } from 'src/app/shared/shared.module';
import { CalendarModule } from 'primeng/calendar';
import { IMaskModule } from 'angular-imask';
import { PurchaseListComponent } from './purchase-list/purchase-list.component';

@NgModule({
  declarations: [PurchaseListComponent, PurchaseFormComponent],
  imports: [
    CommonModule,
    PurchasesRoutingModule,
    CalendarModule,
    IMaskModule,
    SharedModule
  ]
})
export class PurchaseModule { }
