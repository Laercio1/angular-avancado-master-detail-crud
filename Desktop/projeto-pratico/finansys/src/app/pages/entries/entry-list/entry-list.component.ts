import { Component } from '@angular/core';

import { Entry } from "../shared/entry.model";
import { EntryService } from '../shared/entry.service';

import { BaserResourceListComponent } from '../../../shared/components/base-resource-list/base-resource-list.component';

@Component({
  selector: 'app-entry-list',
  templateUrl: './entry-list.component.html',
  styleUrls: ['./entry-list.component.css']
})
export class EntryListComponent extends BaserResourceListComponent<Entry> {

  constructor(private entryService: EntryService) {
    super(entryService)
  }

}
