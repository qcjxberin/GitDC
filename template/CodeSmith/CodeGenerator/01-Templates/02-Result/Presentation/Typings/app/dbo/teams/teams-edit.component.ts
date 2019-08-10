import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { TeamsViewModel } from './model/teams-view-model';

/**
 * 编辑
 */
@Component({
    selector: 'teams-edit',
    templateUrl: env.prod() ? './html/teams-edit.component.html' : '/view/dbo/teams/edit'
})
export class TeamsEditComponent extends EditComponentBase<TeamsViewModel> {
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