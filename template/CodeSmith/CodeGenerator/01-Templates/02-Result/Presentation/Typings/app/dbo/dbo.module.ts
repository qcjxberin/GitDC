import { NgModule } from '@angular/core';
import { FrameworkModule } from '../framework.module';
import { dboRoutingModule } from './dbo-routing.module';
import { UsersIndexComponent } from './users/users-index.component';
import { UsersEditComponent } from './users/users-edit.component';
import { UsersDetailComponent } from './users/users-detail.component';

/**
 * dbo模块
 */
@NgModule({
    declarations: [
        UsersIndexComponent,UsersEditComponent,UsersDetailComponent,
    ],
    imports: [
        FrameworkModule,dboRoutingModule
    ]
})
export class dboModule {
}