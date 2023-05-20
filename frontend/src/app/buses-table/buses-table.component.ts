import { Component, OnInit } from '@angular/core';
// import { MatDialog } from '@angular/material/dialog';
// import { ReportAggregate } from 'src/app/reports/report'
// import { ReportService } from 'src/app/reports/report.service'
// import { EditPopupComponent } from '../edit-popup/edit-popup.component';
// import { NewAggregatePopupComponent } from '../new-aggregate-popup/new-aggregate-popup.component';
import { TravelTicket } from '../travel-ticket/travelTicket';
import { TravelTicketService } from '../travel-ticket/travelTicket.Services';
import { MatDialog } from '@angular/material/dialog';
import { TicketBoxComponent } from '../ticket-box/ticket-box.component';


@Component({
  selector: 'buses-table',
  templateUrl: './buses-table.component.html',
  providers: [TravelTicketService],
  styleUrls: ['./buses-table.component.scss']
})

export class BusesTableComponent implements OnInit {
  dataSource: TravelTicket[] = [];

  constructor(private travelTicketService: TravelTicketService, public dialog: MatDialog) { }

  getTravelTickets(): void {
    this.travelTicketService.getTickets().subscribe(result => {
      this.dataSource = result;
    });
  }

  lookForBuses(): void {
    this.openCreateDialog(new TravelTicket());
  }

  openCreateDialog(row: TravelTicket): void {
    const dialogRef = this.dialog.open(TicketBoxComponent);

    // dialogRef.afterClosed().subscribe(result => {
    //   this.getReportAggregates();
    // });
  }

  ngOnInit(): void {
    this.getTravelTickets();
  }
}