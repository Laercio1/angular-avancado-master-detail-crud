import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './pages/authentication/login/login.component';
import { RegistrationComponent } from './pages/authentication/registration/registration.component';

const routes: Routes = [
  { path: '', redirectTo: 'login', pathMatch: 'full' },
  { path: 'categories', loadChildren: './pages/categories/categories.module#CategoriesModule' },
  { path: 'sales', loadChildren: './pages/sales/sales.module#SalesModule' },
  { path: 'dashboard', loadChildren: './pages/dashboard/dashboard.module#DashboardModule' },
  { path: 'report', loadChildren: './pages/report/report.module#ReportModule' },
  { path: 'products', loadChildren: './pages/products/products.module#ProductsModule' },
  { path: 'purchase', loadChildren: './pages/purchase/purchase.module#PurchaseModule' },
  { path: 'customers', loadChildren: './pages/customers/customers.module#CustomersModule' },
  { path: 'login', component: LoginComponent },
  { path: 'registration', component: RegistrationComponent },
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
