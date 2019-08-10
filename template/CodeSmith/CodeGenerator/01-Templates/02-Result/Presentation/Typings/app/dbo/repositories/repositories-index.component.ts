import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { RepositoriesQuery } from './model/repositories-query';
import { RepositoriesViewModel } from './model/repositories-view-model';

/**
 * 首页
 */
@Component({
    selector: 'repositories-index',
    templateUrl: env.prod() ? './html/repositories-index.component.html' : '/view/dbo/repositories'
})
export class RepositoriesIndexComponent extends TableQueryComponentBase<RepositoriesViewModel, RepositoriesQuery>  {
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
        return new RepositoriesQuery();
    }
}