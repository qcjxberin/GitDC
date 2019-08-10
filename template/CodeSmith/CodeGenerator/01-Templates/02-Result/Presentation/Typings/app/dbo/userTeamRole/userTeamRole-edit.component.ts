import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { UserTeamRoleViewModel } from './model/userTeamRole-view-model';

/**
 * 编辑
 */
@Component({
    selector: 'userTeamRole-edit',
    templateUrl: env.prod() ? './html/userTeamRole-edit.component.html' : '/view/dbo/userTeamRole/edit'
})
export class UserTeamRoleEditComponent extends EditComponentBase<UserTeamRoleViewModel> {
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
        return new UserTeamRoleViewModel();
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "userTeamRole";
    }
}