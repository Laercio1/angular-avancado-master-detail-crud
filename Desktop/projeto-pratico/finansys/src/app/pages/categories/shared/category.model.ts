import { BaseResourceModel } from '../../../shared/models/base-resource.model';
export class Category extends BaseResourceModel {
  constructor(
    public id?: number,
    public namefancy?: string,
    public CNPJ?: string,
    public telephone?: string,
    public email?: string,
    public city?: string,
    public state?: string,
    public country?: string
  ){
    super();
  }

  static fromJson(jsonData: any): Category {
    return Object.assign(new Category(), jsonData);
  }
}
