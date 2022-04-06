import { Component, Injector } from '@angular/core';
import { Validators } from '@angular/forms';

import { BaseResourceFormComponent } from '../../../shared/components/base-resource-form/base-resource-form.component';

import { Customer } from '../shared/customer.model';
import { CustomerService } from '../shared/customer.service';
@Component({
  selector: 'app-customer-form',
  templateUrl: './customer-form.component.html',
  styleUrls: ['./customer-form.component.css']
})
export class CustomerFormComponent extends BaseResourceFormComponent<Customer> {

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
    protected customerService: CustomerService, protected injector: Injector) {
      super(injector, new Customer(), customerService, Customer.fromJson)
    }

  protected buildResourceForm(){
    this.resourceForm = this.formBuilder.group({
      id: [null],
      name: [null, [Validators.required, Validators.minLength(2)]],
      CNPJ_CPF: [null, [Validators.required]],
      birth_date: [null, [Validators.required]], //Data de Nascimento
      address: [null, [Validators.required]], // Endereço
      district: [null, [Validators.required]], // Bairro
      telephone: [null, [Validators.required]],
      email: [null, [Validators.required, Validators.email]],
      city: [null, [Validators.required]],
      state: [null, [Validators.required]],
      country: [null, [Validators.required]],
      description: [null]
    });
  }

  protected creationPageTitle(): string {
      return 'Cadastro de Novo Cliente';
  }

  protected editionPageTitle(): string {
    const customerName = this.resource.name || "";
      return 'Editando Cliente: ' + customerName
  }

}
