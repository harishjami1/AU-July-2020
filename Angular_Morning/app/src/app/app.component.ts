import { Component } from '@angular/core';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
 
  arr=[
    { 
      title:"First",
      id:"1",
    },
    {
      title:"Second",
      id:"2",
    },
    {
      title:"Third",
      id:"3",
    }
  ]


  log(str:string):void{
    console.log('clicked'+str);
  };
}