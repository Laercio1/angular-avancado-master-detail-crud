import { Component } from '@angular/core';

import { Category } from "../shared/category.model";
import { CategoryService } from '../shared/category.service';

import { BaserResourceListComponent } from '../../../shared/components/base-resource-list/base-resource-list.component';
@Component({
  selector: 'app-category-list',
  templateUrl: './category-list.component.html',
  styleUrls: ['./category-list.component.css']
})
export class CategoryListComponent extends BaserResourceListComponent<Category> {

  constructor(private categoryService: CategoryService) {
    super(categoryService)
  }

}
