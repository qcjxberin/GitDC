import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { WHMiddlewareViewModel } from './model/wHMiddleware-view-model';

/**
 * 网络勾子中转表详细
 */
@Component({
    selector: 'wHMiddleware-detail',
    templateUrl: env.prod() ? './html/wHMiddleware-detail.component.html' : '/view/dbo/wHMiddleware/detail'
})
export class WHMiddlewareDetailComponent extends EditComponentBase<WHMiddlewareViewModel> {
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
        return new WHMiddlewareViewModel();
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "wHMiddleware";
    }
}