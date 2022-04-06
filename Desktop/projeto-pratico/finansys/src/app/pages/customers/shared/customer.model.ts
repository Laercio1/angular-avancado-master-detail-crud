import { BaseResourceModel } from '../../../shared/models/base-resource.model';
export class Customer extends BaseResourceModel {
  constructor(
    public id?: number,
    public name?: string,
    public CNPJ_CPF?: string,
    public birth_date?: string,
    public address?: string,
    public district?: string,
    public telephone?: string,
    public email?: string,
    public city?: string,
    public state?: string,
    public country?: string,
    public description?: string
  ){
    super();
  }

  static fromJson(jsonData: any): Customer {
    return Object.assign(new Customer(), jsonData);
  }
}
