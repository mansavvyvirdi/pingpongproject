import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule} from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule } from '@angular/router'

import { AppComponent } from './app.component';
import { PlayerService } from './shared/player.service';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ToastrModule } from 'ngx-toastr';
import { HomeComponent } from './home/home.component';
import { appRoutes } from './routes';
import { MatSelectModule } from '@angular/material/select';



@NgModule({
  declarations: [
    AppComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    MatSelectModule,
    ToastrModule.forRoot({
      positionClass: 'toast-bottom-right',
    }),
    BrowserAnimationsModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [
    PlayerService,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
