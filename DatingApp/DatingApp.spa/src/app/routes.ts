import { Routes } from '@angular/router';
import { MemberListComponent } from './members/member-list/member-list.component';
import { MessagesComponent } from './messages/messages.component';
import { ListsComponent } from './lists/lists.component';
import { HomeComponent } from './home/home.component';
import { AuthGuard } from './_guards/auth.guard';
import { MemberDetailComponent } from './members/member-detail/member-detail.component';

export const appRoutes: Routes = [
    {path: 'home' , component : HomeComponent},
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            {path: 'members' , component : MemberListComponent},
            {path: 'members/:id' , component: MemberDetailComponent},
            {path: 'message' , component : MessagesComponent},
            {path: 'lists' , component : ListsComponent},
        ]
    },
    {path: '**' , redirectTo : 'home' , pathMatch : 'full'}

];
