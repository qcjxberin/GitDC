import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UsersIndexComponent } from './users/users-index.component';
import { UsersEditComponent } from './users/users-edit.component';
import { UsersDetailComponent } from './users/users-detail.component';

//路由配置
const routes: Routes = [
    {
        path: '',
        children: [
            {path: 'users', children: [
                { path: '', component: UsersIndexComponent },
                { path: 'create', component: UsersEditComponent },
                { path: 'update/:id', component: UsersEditComponent },
                { path: 'detail/:id', component: UsersDetailComponent }
            ]},
        ]
    }
];

/**
 * dbo路由模块
 */
@NgModule({
    imports: [RouterModule.forChild(routes)]
})
export class dboRoutingModule { }