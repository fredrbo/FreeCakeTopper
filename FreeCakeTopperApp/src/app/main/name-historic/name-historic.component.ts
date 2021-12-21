import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-name-historic',
  templateUrl: './name-historic.component.html',
  styleUrls: ['./name-historic.component.css']
})
export class NameHistoricComponent implements OnInit {

  constructor() { }
  
  public toppers = [
    { nome: 'ze', color: 'red' },
    { nome: 'andre', color: 'black' },
    { nome: 'roberson', color: 'blue' },
    { nome: 'braba', color: 'yellow' },
  ]

  ngOnInit(): void {
  }

}
