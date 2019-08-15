import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { DCRepositoriesQuery } from './model/dCRepositories-query';
import { DCRepositoriesViewModel } from './model/dCRepositories-view-model';

/**
 * 仓库表首页
 */
@Component({
    selector: 'dCRepositories-index',
    templateUrl: env.prod() ? './html/dCRepositories-index.component.html' : '/view/dbo/dCRepositories'
})
export class DCRepositoriesIndexComponent extends TableQueryComponentBase<DCRepositoriesViewModel, DCRepositoriesQuery>  {
    /**
     * 初始化仓库表首页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }
    
    /**
     * 创建查询参数
     */
    protected createQuery() {
        return new DCRepositoriesQuery();
    }
}