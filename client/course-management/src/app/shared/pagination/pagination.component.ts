import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-pagination',
  templateUrl: './pagination.component.html',
  styleUrls: ['./pagination.component.css']
})
export class PaginationComponent implements OnInit {

  displayPages: number[]
  _currentpage: number
  @Input() get currentPage(){
    return this._currentpage
  }
  set currentPage(value: number){
    if (value) {
      this._currentpage = (value >= 1) ? +value : 1
      console.log('curr page: ', this.currentPage)
      this.displayPages = (this.currentPage === 1) ?
        [this.currentPage, this.currentPage + 1, this.currentPage + 2] :
        [this.currentPage - 1, this.currentPage, this.currentPage + 1]
      console.log('pages: ', this.displayPages)
    }
  }
  @Output() pageChanged: EventEmitter<number> = new EventEmitter<number>() 

  constructor() {}
  ngOnInit(): void {}
  
  onPageClick(curr: string){
    let current: number
    switch(curr){
      case 'prev': {
        current = this.currentPage - 1
        break
      }
      case 'next':{
        current = this.currentPage + 1
        break
      }
      default: {
        current = +curr
        break;
      }
    }
    console.log('current page after clicked: ', current)
    this.pageChanged.emit(current)
  }

}
