import { Component, OnInit } from '@angular/core';
import{PopupService} from '../popup.service';
import{PopService} from '../pop.service';
import { ArrayType, CompileMetadataResolver } from '@angular/compiler';
import { UrlSerializer } from '@angular/router';
@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.scss']
})
export class UserListComponent implements OnInit {

  constructor(public popservice:PopService){}

  
  showDialog=false;
  DeleteUser=false;
  EditUser=false;
  AddUser=false;


onedit(user :string){
  this.popservice.id=user;
  
  this.popservice.ShowDialog=true;
  this.popservice.showEditUser=true;
  
  
}
onclose(){
  
  this.popservice.ShowDialog=false;
  if(this.popservice.showDeleteUser)
  this.popservice.showDeleteUser=false;
  if(this.popservice.showEditUser)
  this.popservice.showEditUser=false;
  if(this.popservice.showAddUser)
  this.popservice.showAddUser=false;
}
onDelete(user:string){
  
  this.popservice.id=user;
  this.popservice.ShowDialog=true;
  
  this.popservice.showDeleteUser=true;
  console.log(this.popservice.id);
  console.log(user);
}
onAdd(){
  this.popservice.ShowDialog=true;
  this.popservice.showAddUser=true;
}

ngOnInit(): void {
 
  sessionStorage.setItem('records',JSON.stringify([{
		firstName:'Kumar',
		lastName:'Varma',
		age:'32',
		empId:'101',
		State : 'Rajasthan'
		},
		{
		firstName:'Vignan',
		lastName:'Vasanth',
		age:'25',
		empId:'231',
		State : 'Karnataka'
    },
  {
    firstName :'Anand',
    lastName:'Awasthi',
    age :'28',
    empId:'176',
    State :'Punjab'

  }]))
    this.popservice.users=JSON.parse(sessionStorage.getItem('records'));
    
   }
  
ngOnChanges(){
 this.popservice.setUsers();
  
}

}
