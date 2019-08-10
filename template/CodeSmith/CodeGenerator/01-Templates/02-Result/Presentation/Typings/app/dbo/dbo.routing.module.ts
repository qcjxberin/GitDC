import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DCUsersIndexComponent } from './dCUsers/dCUsers-index.component';
import { DCUsersEditComponent } from './dCUsers/dCUsers-edit.component';
import { DCUsersDetailComponent } from './dCUsers/dCUsers-detail.component';
import { WHLogsIndexComponent } from './wHLogs/wHLogs-index.component';
import { WHLogsEditComponent } from './wHLogs/wHLogs-edit.component';
import { WHLogsDetailComponent } from './wHLogs/wHLogs-detail.component';
import { WHMiddlewareIndexComponent } from './wHMiddleware/wHMiddleware-index.component';
import { WHMiddlewareEditComponent } from './wHMiddleware/wHMiddleware-edit.component';
import { WHMiddlewareDetailComponent } from './wHMiddleware/wHMiddleware-detail.component';

//路由配置
const routes: Routes = [
    {
        path: '',
        children: [
            {path: 'dCUsers', children: [
                { path: '', component: DCUsersIndexComponent },
                { path: 'create', component: DCUsersEditComponent },
                { path: 'update/:id', component: DCUsersEditComponent },
                { path: 'detail/:id', component: DCUsersDetailComponent }
            ]},
            {path: 'wHLogs', children: [
                { path: '', component: WHLogsIndexComponent },
                { path: 'create', component: WHLogsEditComponent },
                { path: 'update/:id', component: WHLogsEditComponent },
                { path: 'detail/:id', component: WHLogsDetailComponent }
            ]},
            {path: 'wHMiddleware', children: [
                { path: '', component: WHMiddlewareIndexComponent },
                { path: 'create', component: WHMiddlewareEditComponent },
                { path: 'update/:id', component: WHMiddlewareEditComponent },
                { path: 'detail/:id', component: WHMiddlewareDetailComponent }
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