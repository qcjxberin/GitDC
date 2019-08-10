import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { UserRepositoryRoleQuery } from './model/userRepositoryRole-query';
import { UserRepositoryRoleViewModel } from './model/userRepositoryRole-view-model';

/**
 * 首页
 */
@Component({
    selector: 'userRepositoryRole-index',
    templateUrl: env.prod() ? './html/userRepositoryRole-index.component.html' : '/view/dbo/userRepositoryRole'
})
export class UserRepositoryRoleIndexComponent extends TableQueryComponentBase<UserRepositoryRoleViewModel, UserRepositoryRoleQuery>  {
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
        return new UserRepositoryRoleQuery();
    }
}