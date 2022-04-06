import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ProductsRoutingModule } from './products-routing.module';
import { ProductListComponent } from './product-list/product-list.component';
import { ProductFormComponent } from './product-form/product-form.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { IMaskModule } from 'angular-imask';

@NgModule({
  declarations: [ProductListComponent, ProductFormComponent],
  imports: [
    CommonModule,
    ProductsRoutingModule,
    IMaskModule,
    SharedModule
  ]
})
export class ProductsModule { }
