import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NameHistoricComponent } from './name-historic.component';

describe('NameHistoricComponent', () => {
  let component: NameHistoricComponent;
  let fixture: ComponentFixture<NameHistoricComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NameHistoricComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NameHistoricComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
