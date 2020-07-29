import { Component, OnInit } from '@angular/core';
import{PopService} from '../pop.service';
@Component({
  selector: 'app-user-delete',
  templateUrl: './user-delete.component.html',
  styleUrls: ['./user-delete.component.scss']
})
export class UserDeleteComponent implements OnInit {

  constructor(public popservice1:PopService) { }
  delete(){
    this.popservice1.showDeleteUser=false;
    this.popservice1.ShowDialog=false;
    this.popservice1.deleteStorage();}
  ngOnInit(): void {
  }

}
