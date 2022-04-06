import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import {  SaleListComponent } from "./sale-list/sale-list.component"
import { SaleFormComponent } from './sale-form/sale-form.component';

const routes: Routes = [
  { path: '', component: SaleListComponent },
  { path: 'new', component: SaleFormComponent },
  { path: ':id/edit', component: SaleFormComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SalesRoutingModule { }
