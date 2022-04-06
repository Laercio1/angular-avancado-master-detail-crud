import { BaseResourceModel } from "src/app/shared/models/base-resource.model";
import { Category } from "../../categories/shared/category.model";
import { Product } from "../../products/shared/product.model";

export class Purchase extends BaseResourceModel {

  constructor(
   public id?: number,
   public description?: string,
   public type: string = 'expense',
   public amount?: string,
   public date?: string,
   public paid?: boolean,
   public productId?: number,
   public product?: Product,
   public categoryId?: number, //Fornecedor
   public category?: Category, //Fornecedor
   public buyer?: string, //Comprador
   public quatity?: number
  ){
    super()
  }

  static fromJson(jsonData: any): Purchase {
    return Object.assign(new Purchase(), jsonData);
  }

  get paidText(): string {
    return this.paid ? 'Dinheiro' : 'Boleto';
  }
}
