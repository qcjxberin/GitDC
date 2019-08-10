import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { TeamsQuery } from './model/teams-query';
import { TeamsViewModel } from './model/teams-view-model';

/**
 * 首页
 */
@Component({
    selector: 'teams-index',
    templateUrl: env.prod() ? './html/teams-index.component.html' : '/view/dbo/teams'
})
export class TeamsIndexComponent extends TableQueryComponentBase<TeamsViewModel, TeamsQuery>  {
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
        return new TeamsQuery();
    }
}