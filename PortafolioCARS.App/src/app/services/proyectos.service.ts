import { Injectable } from '@angular/core';
import { MisproyectosModel } from '../models/MisProyectosModel';

import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment.development';

@Injectable({
  providedIn: 'root'
})

export class ProyectosService {

  url='Misproyectos';

  constructor(private http: HttpClient) { }

  // public getDriver():Observable<Driver[]>{
  //   return this.http.get<Driver[]>(`${environment.apiUrl}/${this.url}`);
  // }
  public getDriver():Observable<MisproyectosModel[]>{
    return this.http.get<MisproyectosModel[]>(`${environment.apiUrl}`+this.url);
  }
}