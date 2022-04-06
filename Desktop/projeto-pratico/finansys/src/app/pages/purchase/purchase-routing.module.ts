import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PurchaseFormComponent } from "../purchase/purchase-form/purchase-form.component";
import { PurchaseListComponent } from './purchase-list/purchase-list.component';

const routes: Routes = [
  { path: '', component: PurchaseListComponent },
  { path: 'new', component: PurchaseFormComponent },
  { path: ':id/edit', component: PurchaseFormComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PurchasesRoutingModule { }
