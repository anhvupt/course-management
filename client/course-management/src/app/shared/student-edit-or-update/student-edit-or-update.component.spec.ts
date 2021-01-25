import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentEditOrUpdateComponent } from './student-edit-or-update.component';

describe('StudentEditOrUpdateComponent', () => {
  let component: StudentEditOrUpdateComponent;
  let fixture: ComponentFixture<StudentEditOrUpdateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StudentEditOrUpdateComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StudentEditOrUpdateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
