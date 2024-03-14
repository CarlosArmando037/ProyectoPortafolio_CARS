import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MisproyectosModel } from './models/MisProyectosModel';
import { ProyectosService } from './services/proyectos.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent 
{
  title = 'PortafolioCARS.App';
  proyectos:MisproyectosModel[]=[];

  constructor(private proyectoservices : ProyectosService){}
    ngOnInit(): void {
      this.proyectoservices.getDriver().subscribe((result: MisproyectosModel[])=>{
        this.proyectos =result;});
  }
}
