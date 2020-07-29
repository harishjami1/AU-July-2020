import { Component, OnInit } from '@angular/core';
import { FormBuilder ,Validators, FormGroup} from '@angular/forms';
import {PopService} from '../pop.service';
@Component({
  selector: 'app-user-edit',
  templateUrl: './user-edit.component.html',
  styleUrls: ['./user-edit.component.scss']
})
export class UserEditComponent implements OnInit {

  constructor(private form:FormBuilder, public popservice:PopService) { }
  index :number;
  editform=this.form.group({
    empId:['',[Validators.required,Validators.pattern(/[1234567890]+/)]],
    firstName:['',Validators.required],
    lastName:[''],
    age:[''],
    State :['']
  })
  onSubmit(){
    this.popservice.ShowDialog=false;
    this.popservice.showEditUser=false;
    this.popservice.users[this.index]=this.editform.value;
    console.log(this.editform.value);
    console.log(this.popservice.users[this.index]);
    this.popservice.setStorage();
  }

  ngOnInit(): void {
for(let i=0;i<this.popservice.users.length;i++){
  if(this.popservice.users[i].empId==this.popservice.id)
  this.index=i;
  console.log(this.index);
}
  }

}
