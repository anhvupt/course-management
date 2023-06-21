import { Injectable } from '@angular/core';
import { ComponentStore } from '@ngrx/component-store';

@Injectable()
export class InstructorsStore extends ComponentStore<any> {
  constructor() {
    super({ instructors: [] });
  }
}
