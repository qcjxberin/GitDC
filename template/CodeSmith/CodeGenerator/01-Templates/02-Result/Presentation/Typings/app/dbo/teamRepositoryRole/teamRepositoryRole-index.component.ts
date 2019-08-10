import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { TeamRepositoryRoleQuery } from './model/teamRepositoryRole-query';
import { TeamRepositoryRoleViewModel } from './model/teamRepositoryRole-view-model';

/**
 * 首页
 */
@Component({
    selector: 'teamRepositoryRole-index',
    templateUrl: env.prod() ? './html/teamRepositoryRole-index.component.html' : '/view/dbo/teamRepositoryRole'
})
export class TeamRepositoryRoleIndexComponent extends TableQueryComponentBase<TeamRepositoryRoleViewModel, TeamRepositoryRoleQuery>  {
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
        return new TeamRepositoryRoleQuery();
    }
}