import { Component, Inject } from '@angular/core';
import { TravelTicketService } from '../travel-ticket/travelTicket.Services';
import { FormControl } from '@angular/forms';
import { TravelTicket } from '../travel-ticket/travelTicket';

@Component({
    selector: 'ticket-box',
    templateUrl: './ticket-box.component.html',
    providers: [TravelTicketService],
    styleUrls: ['./ticket-box.component.scss']
})

export class TicketBoxComponent{
    protected travelTicket: TravelTicket;
    fromControl: FormControl;
    toControl: FormControl;
    dateControl: FormControl;

    constructor(

      ) {
        this.travelTicket = new TravelTicket();
        this.fromControl = new FormControl(this.travelTicket.from);
        this.toControl = new FormControl(this.travelTicket.to);
        this.dateControl = new FormControl(this.travelTicket.date);
      }
}