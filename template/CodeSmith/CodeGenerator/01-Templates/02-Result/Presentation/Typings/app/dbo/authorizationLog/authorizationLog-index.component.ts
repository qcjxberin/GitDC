import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { AuthorizationLogQuery } from './model/authorizationLog-query';
import { AuthorizationLogViewModel } from './model/authorizationLog-view-model';

/**
 * 首页
 */
@Component({
    selector: 'authorizationLog-index',
    templateUrl: env.prod() ? './html/authorizationLog-index.component.html' : '/view/dbo/authorizationLog'
})
export class AuthorizationLogIndexComponent extends TableQueryComponentBase<AuthorizationLogViewModel, AuthorizationLogQuery>  {
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
        return new AuthorizationLogQuery();
    }
}