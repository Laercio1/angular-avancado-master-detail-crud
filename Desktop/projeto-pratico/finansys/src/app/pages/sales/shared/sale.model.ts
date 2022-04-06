import { BaseResourceModel } from '../../../shared/models/base-resource.model';
import { Customer } from '../../customers/shared/customer.model';
import { Product } from "../../products/shared/product.model";

export class Sale extends BaseResourceModel {
  constructor(
    public id?: number,
    public description?: string,
    public type: string = 'revenue',
    public amount?: string,
    public date?: string,
    public paid?: boolean,
    public productId?: number,
    public product?: Product,
    public vendor?: string,
    public quatity?: number,
    public customerId?: number,
    public customer?: Customer,

  ){
    super();
  }

  static fromJson(jsonData: any): Sale {
    return Object.assign(new Sale(), jsonData);
  }

  get paidText(): string {
    return this.paid ? 'Dinheiro' : 'Cartão';
  }
}
