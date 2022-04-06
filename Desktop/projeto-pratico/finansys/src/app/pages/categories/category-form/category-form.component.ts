import { Component, Injector } from '@angular/core';
import { Validators } from '@angular/forms';

import { BaseResourceFormComponent } from '../../../shared/components/base-resource-form/base-resource-form.component';

import { Category } from '../shared/category.model';
import { CategoryService } from '../shared/category.service';
@Component({
  selector: 'app-category-form',
  templateUrl: './category-form.component.html',
  styleUrls: ['./category-form.component.css']
})
export class CategoryFormComponent extends BaseResourceFormComponent<Category> {

  constructor(
    protected categoryService: CategoryService, protected injector: Injector) {
      super(injector, new Category(), categoryService, Category.fromJson)
    }

  protected buildResourceForm(){
    this.resourceForm = this.formBuilder.group({
      id: [null],
      namefancy: [null, [Validators.required, Validators.minLength(2)]], //Nome fantasia
      CNPJ: [null, [Validators.required]],
      telephone: [null, [Validators.required]],
      email: [null, [Validators.required, Validators.email]],
      city: [null, [Validators.required]],
      state: [null, [Validators.required]],
      country: [null, [Validators.required]]
    });
  }

  protected creationPageTitle(): string {
      return 'Cadastro de Novo Fornecedor';
  }

  protected editionPageTitle(): string {
    const categoryName = this.resource.namefancy || "";
      return 'Editando Fornecedor: ' + categoryName
  }

}
