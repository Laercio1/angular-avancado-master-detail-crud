import { Component } from '@angular/core';

import { BaserResourceListComponent } from '../../../shared/components/base-resource-list/base-resource-list.component';

import { Product } from '../shared/product.model';
import { ProductService } from '../shared/product.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent extends BaserResourceListComponent<Product> {

  constructor(private productService:ProductService) {
    super(productService)
  }

}
