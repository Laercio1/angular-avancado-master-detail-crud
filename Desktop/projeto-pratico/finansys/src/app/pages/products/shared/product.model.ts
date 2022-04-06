import { BaseResourceModel } from '../../../shared/models/base-resource.model';
import { Category } from '../../categories/shared/category.model';
export class Product extends BaseResourceModel {
  constructor(
    public id?: number,
    public name?: string,
    public description?: string,
    public amount?: string,
    public category?: string,
    public marca?: string,
    public stock?: number
  ){
    super();
  }

  static fromJson(jsonData: any): Product {
    return Object.assign(new Product(), jsonData);
  }
}
