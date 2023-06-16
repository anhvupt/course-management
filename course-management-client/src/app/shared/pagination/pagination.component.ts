import { ChangeDetectionStrategy, Component, 
  EventEmitter, Input, Output } from '@angular/core';
import { NgIf, NgFor } from '@angular/common';

@Component({
    selector: 'app-pagination',
    templateUrl: './pagination.component.html',
    styleUrls: ['./pagination.component.css'],
    changeDetection: ChangeDetectionStrategy.OnPush,
    standalone: true,
    imports: [NgIf, NgFor]
})
export class PaginationComponent{

  displayPages: number[] = []
  _currentpage: number
  _totalPage: number
  @Input() get totalPage(){
    return this._totalPage
  }
  @Input() get currentPage(){
    return this._currentpage
  }
  set currentPage(value: number){
    this._currentpage = +value      
    this.generatePager()
  }
  set totalPage(value: number){
    this._totalPage = value
    this.generatePager()
  }
  @Output() pageChanged: EventEmitter<number> = new EventEmitter<number>() 

  constructor() { }
  
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
    this.pageChanged.emit(current)
  }

  generatePager() {
    this.displayPages = []
    let first, second, third
    if (this.currentPage === 1) {
      first = this.currentPage
      second = (this.currentPage + 1 <= this.totalPage) ? this.currentPage + 1 : 0
      third = (this.currentPage + 2 <= this.totalPage) ? this.currentPage + 2 : 0
    } else {
      first = this.currentPage - 1
      second = this.currentPage
      third = (this.currentPage + 1 <= this.totalPage) ? this.currentPage + 1 : 0
    }
    if (first) this.displayPages.push(first)
    if (second) this.displayPages.push(second)
    if (third) this.displayPages.push(third)
    console.log('current page: ', this.currentPage), console.log('totalPage: ', this.totalPage)
  }
}
