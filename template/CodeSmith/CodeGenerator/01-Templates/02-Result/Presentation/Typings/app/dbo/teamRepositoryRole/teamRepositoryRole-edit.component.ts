import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { TeamRepositoryRoleViewModel } from './model/teamRepositoryRole-view-model';

/**
 * 编辑
 */
@Component({
    selector: 'teamRepositoryRole-edit',
    templateUrl: env.prod() ? './html/teamRepositoryRole-edit.component.html' : '/view/dbo/teamRepositoryRole/edit'
})
export class TeamRepositoryRoleEditComponent extends EditComponentBase<TeamRepositoryRoleViewModel> {
    /**
     * 初始化组件
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }
    
    /**
     * 创建视图模型
     */
    protected createModel() {
        return new TeamRepositoryRoleViewModel();
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "teamRepositoryRole";
    }
}