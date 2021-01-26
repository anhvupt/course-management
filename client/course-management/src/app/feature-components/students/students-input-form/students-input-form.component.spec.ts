import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentsInputFormComponent } from './students-input-form.component';

describe('StudentsInputFormComponent', () => {
  let component: StudentsInputFormComponent;
  let fixture: ComponentFixture<StudentsInputFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StudentsInputFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StudentsInputFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
