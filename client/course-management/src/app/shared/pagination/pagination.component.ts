import { ConditionalExpr } from '@angular/compiler';
import { ChangeDetectionStrategy, Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-pagination',
  templateUrl: './pagination.component.html',
  styleUrls: ['./pagination.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class PaginationComponent implements OnInit {

  displayPages: number[] = []
  _currentpage: number
  @Input() totalPage
  @Input() get currentPage(){
    return this._currentpage
  }
  set currentPage(value: number){
    if (value) {
      this._currentpage = (value >= 1) ? +value : 1
      let first, second, third
      if (value === 1) {
        first = this.currentPage
        second = (this.currentPage + 1 < this.totalPage) ? this.currentPage + 1 : 0
        third = (this.currentPage + 2 < this.totalPage) ? this.currentPage + 2 : 0
      } else {
        first = this.currentPage - 1
        second = this.currentPage
        third = (this.currentPage + 1 <= this.totalPage) ? this.currentPage + 1 : 0
      }
      //this.displayPages = [first, second, third]
      if(first) this.displayPages.push(first)
      if(second) this.displayPages.push(second)
      if(third) this.displayPages.push(third)
    }
  }
  @Output() pageChanged: EventEmitter<number> = new EventEmitter<number>() 

  constructor() {}
  ngOnInit(): void {console.log(this.currentPage)}
  
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

}
