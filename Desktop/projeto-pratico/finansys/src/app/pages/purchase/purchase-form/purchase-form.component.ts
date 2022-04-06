import { Component, Injector } from '@angular/core';
import { Validators } from '@angular/forms';

import { BaseResourceFormComponent } from '../../../shared/components/base-resource-form/base-resource-form.component';
import { Category } from '../../categories/shared/category.model';
import { CategoryService } from '../../categories/shared/category.service';
import { Product } from '../../products/shared/product.model';
import { ProductService } from '../../products/shared/product.service';

import { Purchase } from '../shared/purchase.model';
import { PurchaseService } from '../shared/purchase.service';


@Component({
  selector: 'app-purchase-form',
  templateUrl: './purchase-form.component.html',
  styleUrls: ['./purchase-form.component.css']
})
export class PurchaseFormComponent extends BaseResourceFormComponent<Purchase> {

  products: Array<Product>;
  categories: Array<Category>

  imaskConfig = {
  mask: Number,
  scale: 2,
  thousandsSeparator: '',
  padFractionalZeros: true,
  normalizeZeros: true,
  radix: ','
  }

  ptBR = {
    firstDayOfWeek: 0,
    dayNames: ['Domingo', 'Segunda', 'Terça', 'Quarta', 'Quinta', 'Sexta', 'Sábado'],
    dayNamesShort: ['Dom', 'Seg', 'Ter', 'Qua', 'Qui', 'Sex', 'Sab'],
    dayNamesMin: ['Do', 'Se', 'Te', 'Qu', 'Qu', 'Se', 'Sa'],
    monthNames: [
      'Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho', 'Julho',
      'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro'
    ],
    monthNamesShort: ['Jan', 'Fev', 'Mar', 'Abr', 'Mai', 'Jun', 'Jul', 'Ago', 'Set', 'Out', 'Nov', 'Dez'],
    today: 'Hoje',
    clear: 'Limpar'
  }

  constructor(
    protected categoryService: CategoryService,
    protected purchaseService: PurchaseService,
    protected productService: ProductService,
    protected injector: Injector) {
      super(injector, new Purchase(), purchaseService, Purchase.fromJson)
     }

  ngOnInit() {
    this.loadProducts();
    this.loadCategory();
    super.ngOnInit();
  }

  protected buildResourceForm(){
    this.resourceForm = this.formBuilder.group({
      id: [null],
      buyer: [null, [Validators.required, Validators.minLength(2)]],
      description: [null,],
      quatity: [null, [Validators.required]],
      amount: [null, [Validators.required]],
      date: [null, [Validators.required]],
      paid: [true, [Validators.required]],
      productId: [null, [Validators.required]],
      categoryId: [null, [Validators.required]]
    });
  }

  private loadProducts(){
    this.productService.getAll().subscribe(
      products => this.products = products
    );
  }

  private loadCategory(){
    this.categoryService.getAll().subscribe(
      categories => this.categories = categories
    );
  }

  protected creationPageTitle(): string {
    return 'Cadastro de Nova Compra';
}

protected editionPageTitle(): string {
  const resourceName = this.resource.product.name || "";
    return 'Editando compra do produto: ' + resourceName
}

}

