import { TestBed } from '@angular/core/testing';

import { DatosEjerciciosService } from './datos-ejercicios.service';

describe('DatosEjerciciosService', () => {
  let service: DatosEjerciciosService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DatosEjerciciosService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
