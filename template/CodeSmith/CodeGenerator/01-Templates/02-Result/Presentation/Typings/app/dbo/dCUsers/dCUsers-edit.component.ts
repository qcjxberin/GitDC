import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { DCUsersViewModel } from './model/dCUsers-view-model';

/**
 * 用户名编辑
 */
@Component({
    selector: 'dCUsers-edit',
    templateUrl: env.prod() ? './html/dCUsers-edit.component.html' : '/view/dbo/dCUsers/edit'
})
export class DCUsersEditComponent extends EditComponentBase<DCUsersViewModel> {
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
        return new DCUsersViewModel();
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "dCUsers";
    }
}