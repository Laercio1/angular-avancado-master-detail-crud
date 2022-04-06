import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FooterComponent } from './core/components/footer/footer.component';
import { SidebarComponent } from './core/components/sidebar/sidebar.component';

import { CoreModule } from './core/core.module';
import { LoginComponent } from './pages/authentication/login/login.component';
import { RegistrationComponent } from './pages/authentication/registration/registration.component';

@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    SidebarComponent,
    LoginComponent,
    RegistrationComponent
  ],
  imports: [
    AppRoutingModule,
    CoreModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
