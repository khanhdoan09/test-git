import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {RouterModule, Routes} from "@angular/router";
import {HomeComponent} from "./view/home/home.component";
import {LoginComponent} from "./view/authentication/login/login.component";
import {RegisterComponent} from "./view/authentication/register/register.component";
import {RecoverpwComponent} from "./view/authentication/recoverpw/recoverpw.component";


const routes: Routes = [
  {
    path: "home",
    component: HomeComponent,
  },
  {
    path: "logIn",
    component: LoginComponent,
  },
  {
    path: "register",
    component: RegisterComponent,
  },
  {
    path: "recoverPassword",
    component: RecoverpwComponent,
  },
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule { }
