import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { RepositoriesViewModel } from './model/repositories-view-model';

/**
 * 详细
 */
@Component({
    selector: 'repositories-detail',
    templateUrl: env.prod() ? './html/repositories-detail.component.html' : '/view/dbo/repositories/detail'
})
export class RepositoriesDetailComponent extends EditComponentBase<RepositoriesViewModel> {
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