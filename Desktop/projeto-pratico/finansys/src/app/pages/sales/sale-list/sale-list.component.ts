import { Component } from '@angular/core';

import { Sale } from "../shared/sale.model";
import { SaleService } from '../shared/sale.service';

import { BaserResourceListComponent } from '../../../shared/components/base-resource-list/base-resource-list.component';

@Component({
  selector: 'app-sale-list',
  templateUrl: './sale-list.component.html',
  styleUrls: ['./sale-list.component.css']
})
export class SaleListComponent extends BaserResourceListComponent<Sale> {

  constructor(private saleService: SaleService) {
    super(saleService)
   }

}
