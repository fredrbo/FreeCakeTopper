import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-historic',
  templateUrl: './historic.component.html',
  styleUrls: ['./historic.component.css']
})
export class HistoricComponent implements OnInit {

  constructor() { }

  public toppers = [
    { nome: 'ze', color: 'red' },
    { nome: 'andre', color: 'black' },
    { nome: 'roberson', color: 'blue' },
    { nome: 'braba', color: 'yellow' },
    { nome: 'ze', color: 'red' },
    { nome: 'andre', color: 'black' },
    { nome: 'roberson', color: 'blue' },
    { nome: 'braba', color: 'yellow' },
  ]
  ngOnInit(): void {
  }

}
