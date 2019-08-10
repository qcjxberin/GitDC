import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { WHMiddlewareQuery } from './model/wHMiddleware-query';
import { WHMiddlewareViewModel } from './model/wHMiddleware-view-model';

/**
 * 网络勾子中转表首页
 */
@Component({
    selector: 'wHMiddleware-index',
    templateUrl: env.prod() ? './html/wHMiddleware-index.component.html' : '/view/dbo/wHMiddleware'
})
export class WHMiddlewareIndexComponent extends TableQueryComponentBase<WHMiddlewareViewModel, WHMiddlewareQuery>  {
    /**
     * 初始化网络勾子中转表首页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }
    
    /**
     * 创建查询参数
     */
    protected createQuery() {
        return new WHMiddlewareQuery();
    }
}