import { Component } from '@angular/core';

import { BaserResourceListComponent } from 'src/app/shared/components/base-resource-list/base-resource-list.component';

import { Purchase } from '../shared/purchase.model';
import { PurchaseService } from '../shared/purchase.service';

@Component({
  selector: 'app-purchase-list',
  templateUrl: './purchase-list.component.html',
  styleUrls: ['./purchase-list.component.css']
})
export class PurchaseListComponent extends BaserResourceListComponent<Purchase> {

  constructor(private purchaseService: PurchaseService) {
    super(purchaseService)
  }

}
