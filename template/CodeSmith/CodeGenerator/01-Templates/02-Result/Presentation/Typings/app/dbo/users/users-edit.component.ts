import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { UsersViewModel } from './model/users-view-model';

/**
 * 用户名编辑
 */
@Component({
    selector: 'users-edit',
    templateUrl: env.prod() ? './html/users-edit.component.html' : '/view/dbo/users/edit'
})
export class UsersEditComponent extends EditComponentBase<UsersViewModel> {
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
        return new UsersViewModel();
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "users";
    }
}