import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { AuthorizationLogViewModel } from './model/authorizationLog-view-model';

/**
 * 编辑
 */
@Component({
    selector: 'authorizationLog-edit',
    templateUrl: env.prod() ? './html/authorizationLog-edit.component.html' : '/view/dbo/authorizationLog/edit'
})
export class AuthorizationLogEditComponent extends EditComponentBase<AuthorizationLogViewModel> {
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
        return new AuthorizationLogViewModel();
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "authorizationLog";
    }
}