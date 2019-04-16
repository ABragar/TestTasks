import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {
  ChooseElementsComponent,
  DeleteGroupComponent,
  NewPerfomanceComponent,
  newPerfomanceDialog,
  deleteGroupDialog,
  combineUFDialog
} from '@core/components/dialogs';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public dialog: MatDialog;
  public items: BusinessEntity1[];

  private http: HttpClient;
  private baseUrl: string
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
  }

  findItem(text: string): void {
    this.http.get<BusinessEntity1[]>(this.baseUrl + `api/SampleData/search/${text}`).subscribe(result => {
      this.items = result;
    }, error => console.error(error));
  }

  editItem(item: BusinessEntity1): void {
    const dialogRef = this.dialog.open(ChooseElementsComponent, combineUFDialog);
    dialogRef.afterClosed()
      .pipe(
        filter(Boolean),
        untilDestroyed(this)
      )
      .subscribe(() => {
        this.store.dispatch(new ComponentPerformance.SetUnitPricingConnected({ perfId: value }));
      });
  }
}

interface BusinessEntity1 {
  Id: number;
  Name: string;
}
