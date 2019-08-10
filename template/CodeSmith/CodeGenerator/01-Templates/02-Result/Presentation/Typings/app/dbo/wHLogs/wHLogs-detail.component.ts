import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { WHLogsViewModel } from './model/wHLogs-view-model';

/**
 * 网络勾子推送内容日志详细
 */
@Component({
    selector: 'wHLogs-detail',
    templateUrl: env.prod() ? './html/wHLogs-detail.component.html' : '/view/dbo/wHLogs/detail'
})
export class WHLogsDetailComponent extends EditComponentBase<WHLogsViewModel> {
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
        return new WHLogsViewModel();
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "wHLogs";
    }
}