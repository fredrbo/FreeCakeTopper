import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { LoginComponent } from './login/login.component';
import { AppComponent } from './app.component';
import { HistoricComponent } from './main/historic/historic.component';
import { MainComponent } from './main/main.component';
import { NavComponent } from './main/nav/nav.component';
import { CreateTopperComponent } from './main/create-topper/create-topper.component';
import { NameHistoricComponent } from './main/name-historic/name-historic.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSliderModule } from '@angular/material/slider';
import { MatInputModule } from '@angular/material/input'
import { MatButtonModule } from '@angular/material/button';
import { MatGridListModule } from '@angular/material/grid-list';




@NgModule({
  declarations: [
    AppComponent,
    HistoricComponent,
    CreateTopperComponent,
    LoginComponent,
    MainComponent,
    NavComponent,
    NameHistoricComponent
  ],
  imports: [
    MatInputModule,
    MatButtonModule,
    MatSliderModule,
    MatGridListModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
