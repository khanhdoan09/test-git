import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss'],
})
export class ProfileComponent implements OnInit {
  profileForm = new FormGroup({
    name: new FormControl('John Doe'),
    email: new FormControl('johndoe@gmail.com'),
    position: new FormControl('Founder'),
    description: new FormControl(
      'Lorem ipsum dolor sit amet consectetur adipisicing elit. Iusto ullam nihil impedit. Porro minus nemo nobis maiores numquam tempora architecto a, nisi consectetur, expedita illum, debitis aliquam incidunt molestias eveniet.'
    ),
  });

  constructor() {}

  ngOnInit(): void {}
}
