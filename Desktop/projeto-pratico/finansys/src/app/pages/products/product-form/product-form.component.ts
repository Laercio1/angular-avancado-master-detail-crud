import { Component, Injector, OnInit } from '@angular/core';
import { Validators } from '@angular/forms';

import { BaseResourceFormComponent } from '../../../shared/components/base-resource-form/base-resource-form.component';
import { Purchase } from '../../purchase/shared/purchase.model';
import { Category } from '../../categories/shared/category.model';
import { CategoryService } from '../../categories/shared/category.service';

import { Product } from '../shared/product.model';
import { ProductService } from '../shared/product.service';
@Component({
  selector: 'app-product-form',
  templateUrl: './product-form.component.html',
  styleUrls: ['./product-form.component.css']
})
export class ProductFormComponent extends BaseResourceFormComponent<Product> implements OnInit {

  imaskConfig = {
    mask: Number,
    scale: 2,
    thousandsSeparator: '',
    padFractionalZeros: true,
    normalizeZeros: true,
    radix: ','
    }

  constructor(
    protected productService: ProductService, protected injector: Injector) {
      super(injector, new Product(), productService, Product.fromJson)
    }

  protected buildResourceForm(){
    this.resourceForm = this.formBuilder.group({
      id: [null],
      name: [null, [Validators.required, Validators.minLength(2)]],
      description: [null],
      amount: [null, [Validators.required]],
      category: [null, [Validators.required]],
      marca: [null, [Validators.required]],
      stock: [null, [Validators.required]]
    });
  }

  ngOnInit() {
    super.ngOnInit();
  }


  protected creationPageTitle(): string {
      return 'Cadastro de Novo Produto';
  }

  protected editionPageTitle(): string {
    const productName = this.resource.name || "";
      return 'Editando Produto: ' + productName
  }

}
