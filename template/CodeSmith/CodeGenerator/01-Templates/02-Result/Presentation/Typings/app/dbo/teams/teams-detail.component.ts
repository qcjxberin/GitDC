import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { TeamsViewModel } from './model/teams-view-model';

/**
 * 详细
 */
@Component({
    selector: 'teams-detail',
    templateUrl: env.prod() ? './html/teams-detail.component.html' : '/view/dbo/teams/detail'
})
export class TeamsDetailComponent extends EditComponentBase<TeamsViewModel> {
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
        return new TeamsViewModel();
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "teams";
    }
}