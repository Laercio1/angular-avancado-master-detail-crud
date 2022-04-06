import { Component, Injector, OnInit } from '@angular/core';
import { Validators } from '@angular/forms';

import { Sale } from '../shared/sale.model';
import { SaleService } from '../shared/sale.service';

import { Product } from '../../products/shared/product.model';

import { BaseResourceFormComponent } from '../../../shared/components/base-resource-form/base-resource-form.component';
import { ProductService } from '../../products/shared/product.service';
import { CustomerService } from '../../customers/shared/customer.service';
import { Customer } from '../../customers/shared/customer.model';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
@Component({
  selector: 'app-entry-form',
  templateUrl: './sale-form.component.html',
  styleUrls: ['./sale-form.component.css']
})
export class SaleFormComponent extends BaseResourceFormComponent<Sale> implements OnInit {

  products: Array<Product>;
  customers: Array<Customer>;

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
    protected customerService: CustomerService,
    protected saleService: SaleService,
    protected productService: ProductService,
    protected injector: Injector) {
      super(injector, new Sale(), saleService, Sale.fromJson)
     }

  ngOnInit() {
    this.loadProducts();
    this.loadCustomers();
    super.ngOnInit();
  }

  protected buildResourceForm(){
    this.resourceForm = this.formBuilder.group({
      id: [null],
      customerId: [null, [Validators.required]],
      vendor: [null, [Validators.required, Validators.minLength(2)]],
      description: [null,],
      quatity: [null, [Validators.required]],
      amount: [null, [Validators.required]],
      date: [null, [Validators.required]],
      paid: [true, [Validators.required]],
      productId: [null, [Validators.required]],
    });
  }

  private loadProducts(){
    this.productService.getAll().subscribe(
      products => this.products = products
    );
  }

  private loadCustomers(){
    this.customerService.getAll().subscribe(
      customers => this.customers = customers
    );
  }

  protected creationPageTitle(): string {
    return 'Cadastro de Nova Venda';
}

protected editionPageTitle(): string {
  const resourceName = this.resource.product.name || "";
    return 'Editando venda do produto: ' + resourceName
}

}
