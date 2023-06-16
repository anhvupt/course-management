import { Location } from '@angular/common';
import { Component, Input, OnInit } from '@angular/core';

@Component({
    selector: 'app-back-button',
    templateUrl: './back-button.component.html',
    styleUrls: ['./back-button.component.css'],
    standalone: true
})
export class BackButtonComponent implements OnInit {

  constructor(private location: Location) { }

  @Input() text: string

  ngOnInit(): void {
  }

  back(){
    this.location.back()
  }
}
