import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { UsersViewModel } from './model/users-view-model';

/**
 * 用户名详细
 */
@Component({
    selector: 'users-detail',
    templateUrl: env.prod() ? './html/users-detail.component.html' : '/view/dbo/users/detail'
})
export class UsersDetailComponent extends EditComponentBase<UsersViewModel> {
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