import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { DashBoardComponent } from './dash-board/dash-board.component';
import { AppComponent } from './app.component';
import { PaginaNaoEncontradaComponent } from './pagina-nao-encontrada/pagina-nao-encontrada.component';


const routes: Routes = [
  { path: 'app', component: AppComponent },
  { path: 'dashboard', component: DashBoardComponent },
  { path: '**', component: PaginaNaoEncontradaComponent }
];
@NgModule({
  imports: [RouterModule.forRoot(
    routes,
    { enableTracing: true}
  )],
  exports: [RouterModule]
})
export class AppRoutingModule { }
