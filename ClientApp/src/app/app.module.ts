import {FormsModule} from '@angular/forms';
import { VehicleService } from '../../services/vehicle.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import { AppComponent } from './app.component';
import { VehicleFormComponent } from './vehicle-form/vehicle-form.component';
import { RouterModule, Routes } from '@angular/router';
import { NavbarComponent } from './navbar/navbar.component';
import { ITS_JUST_ANGULAR } from '@angular/core/src/r3_symbols';

const appRoutes: Routes= [
  {path: 'vehicles', component:VehicleFormComponent},

];
@NgModule({
  declarations: [
    AppComponent,
    VehicleFormComponent,
    NavbarComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRoutes),
    HttpClientModule,
    FormsModule,
  ],
  providers: [
    VehicleService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
