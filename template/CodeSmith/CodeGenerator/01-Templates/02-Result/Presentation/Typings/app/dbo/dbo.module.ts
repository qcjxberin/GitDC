import { NgModule } from '@angular/core';
import { FrameworkModule } from '../framework.module';
import { dboRoutingModule } from './dbo-routing.module';
import { DCUsersIndexComponent } from './dCUsers/dCUsers-index.component';
import { DCUsersEditComponent } from './dCUsers/dCUsers-edit.component';
import { DCUsersDetailComponent } from './dCUsers/dCUsers-detail.component';
import { WHLogsIndexComponent } from './wHLogs/wHLogs-index.component';
import { WHLogsEditComponent } from './wHLogs/wHLogs-edit.component';
import { WHLogsDetailComponent } from './wHLogs/wHLogs-detail.component';
import { WHMiddlewareIndexComponent } from './wHMiddleware/wHMiddleware-index.component';
import { WHMiddlewareEditComponent } from './wHMiddleware/wHMiddleware-edit.component';
import { WHMiddlewareDetailComponent } from './wHMiddleware/wHMiddleware-detail.component';

/**
 * dbo模块
 */
@NgModule({
    declarations: [
        DCUsersIndexComponent,DCUsersEditComponent,DCUsersDetailComponent,
        WHLogsIndexComponent,WHLogsEditComponent,WHLogsDetailComponent,
        WHMiddlewareIndexComponent,WHMiddlewareEditComponent,WHMiddlewareDetailComponent,
    ],
    imports: [
        FrameworkModule,dboRoutingModule
    ]
})
export class dboModule {
}