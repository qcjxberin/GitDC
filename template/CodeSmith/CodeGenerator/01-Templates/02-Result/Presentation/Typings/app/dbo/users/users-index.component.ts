import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { UsersQuery } from './model/users-query';
import { UsersViewModel } from './model/users-view-model';

/**
 * 用户名首页
 */
@Component({
    selector: 'users-index',
    templateUrl: env.prod() ? './html/users-index.component.html' : '/view/dbo/users'
})
export class UsersIndexComponent extends TableQueryComponentBase<UsersViewModel, UsersQuery>  {
    /**
     * 初始化用户名首页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }
    
    /**
     * 创建查询参数
     */
    protected createQuery() {
        return new UsersQuery();
    }
}