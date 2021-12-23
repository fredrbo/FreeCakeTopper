import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';

interface Font {
  value: string;
}

@Component({
  selector: 'app-create-topper',
  templateUrl: './create-topper.component.html',
  styleUrls: ['./create-topper.component.css']
})
export class CreateTopperComponent implements OnInit {

  constructor(private formBuilder: FormBuilder) { }

  formulario: FormGroup;


  fonts: Font[] = [
    { value: 'Arial' },
    { value: 'Astral Sisters' },
    { value: 'Southmore' },
    { value: 'Winter Christmas' },
    { value: 'TheBlacklight' },];
  ngOnInit(): void {
    this.formulario = this.formBuilder.group({
      name: ['Fred'],
      font: ['Arial'],
      colorFont: ['#AAAAAA'],
      colorStroke: ['#111'],
      strokeWidht: [1]
    })

  }



}


