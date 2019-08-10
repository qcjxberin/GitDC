import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { WHLogsQuery } from './model/wHLogs-query';
import { WHLogsViewModel } from './model/wHLogs-view-model';

/**
 * 网络勾子推送内容日志首页
 */
@Component({
    selector: 'wHLogs-index',
    templateUrl: env.prod() ? './html/wHLogs-index.component.html' : '/view/dbo/wHLogs'
})
export class WHLogsIndexComponent extends TableQueryComponentBase<WHLogsViewModel, WHLogsQuery>  {
    /**
     * 初始化网络勾子推送内容日志首页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }
    
    /**
     * 创建查询参数
     */
    protected createQuery() {
        return new WHLogsQuery();
    }
}