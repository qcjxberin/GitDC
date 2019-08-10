import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { AuthorizationLogViewModel } from './model/authorizationLog-view-model';

/**
 * 详细
 */
@Component({
    selector: 'authorizationLog-detail',
    templateUrl: env.prod() ? './html/authorizationLog-detail.component.html' : '/view/dbo/authorizationLog/detail'
})
export class AuthorizationLogDetailComponent extends EditComponentBase<AuthorizationLogViewModel> {
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