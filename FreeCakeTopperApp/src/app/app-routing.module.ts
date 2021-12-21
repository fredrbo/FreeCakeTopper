import { MainComponent } from './main/main.component';
import { LoginComponent } from './login/login.component';
import { HistoricComponent } from './main/historic/historic.component';
import { CreateTopperComponent } from './main/create-topper/create-topper.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: '', redirectTo: 'login', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'new-topper', component: CreateTopperComponent },
  { path: 'historic', component: HistoricComponent },
  { path: 'main', component: MainComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
