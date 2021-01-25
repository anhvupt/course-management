import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentCreateOrEditComponent } from './student-create-or-edit.component';

describe('StudentCreateOrEditComponent', () => {
  let component: StudentCreateOrEditComponent;
  let fixture: ComponentFixture<StudentCreateOrEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StudentCreateOrEditComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StudentCreateOrEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
