import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { RepositoriesViewModel } from './model/repositories-view-model';

/**
 * 仓库表编辑
 */
@Component({
    selector: 'repositories-edit',
    templateUrl: env.prod() ? './html/repositories-edit.component.html' : '/view/dbo/repositories/edit'
})
export class RepositoriesEditComponent extends EditComponentBase<RepositoriesViewModel> {
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
        return new RepositoriesViewModel();
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "repositories";
    }
}