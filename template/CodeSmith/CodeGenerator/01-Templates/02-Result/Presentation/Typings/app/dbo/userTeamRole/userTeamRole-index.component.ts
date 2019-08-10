import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { UserTeamRoleQuery } from './model/userTeamRole-query';
import { UserTeamRoleViewModel } from './model/userTeamRole-view-model';

/**
 * 首页
 */
@Component({
    selector: 'userTeamRole-index',
    templateUrl: env.prod() ? './html/userTeamRole-index.component.html' : '/view/dbo/userTeamRole'
})
export class UserTeamRoleIndexComponent extends TableQueryComponentBase<UserTeamRoleViewModel, UserTeamRoleQuery>  {
    /**
     * 初始化首页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }
    
    /**
     * 创建查询参数
     */
    protected createQuery() {
        return new UserTeamRoleQuery();
    }
}