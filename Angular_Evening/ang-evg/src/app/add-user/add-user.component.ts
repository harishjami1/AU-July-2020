import { Component, OnInit ,OnDestroy} from '@angular/core';
import { FormBuilder ,Validators, FormGroup} from '@angular/forms';
import {PopService} from '../pop.service';
@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.scss']
})
export class AddUserComponent implements OnInit,OnDestroy {

  constructor(private form:FormBuilder, public popservice:PopService) { }
  addform=this.form.group({
    empId:['',[Validators.required,Validators.pattern(/[1234567890]+/)]],
    firstName:['',Validators.required],
    lastName:[''],
    age:[''],
   State:['']
  })
  onSubmit(){
    this.popservice.ShowDialog=false;
    this.popservice.showAddUser=false;
    this.popservice.users.push(this.addform.value);
    console.log(this.addform.value);
    console.log(this.popservice.users[this.popservice.users.length-1]);
    this.popservice.setStorage();
  }
  ngOnInit(): void {
  }
  ngOnDestroy(){
    console.log(this.popservice.showAddUser);
  }
}
