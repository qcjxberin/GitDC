import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { DCUsersQuery } from './model/dCUsers-query';
import { DCUsersViewModel } from './model/dCUsers-view-model';

/**
 * 用户名首页
 */
@Component({
    selector: 'dCUsers-index',
    templateUrl: env.prod() ? './html/dCUsers-index.component.html' : '/view/dbo/dCUsers'
})
export class DCUsersIndexComponent extends TableQueryComponentBase<DCUsersViewModel, DCUsersQuery>  {
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
        return new DCUsersQuery();
    }
}