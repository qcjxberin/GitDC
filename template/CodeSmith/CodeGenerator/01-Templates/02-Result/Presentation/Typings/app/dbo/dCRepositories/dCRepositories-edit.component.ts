import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { DCRepositoriesViewModel } from './model/dCRepositories-view-model';

/**
 * 仓库表编辑
 */
@Component({
    selector: 'dCRepositories-edit',
    templateUrl: env.prod() ? './html/dCRepositories-edit.component.html' : '/view/dbo/dCRepositories/edit'
})
export class DCRepositoriesEditComponent extends EditComponentBase<DCRepositoriesViewModel> {
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
        return new DCRepositoriesViewModel();
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "dCRepositories";
    }
}