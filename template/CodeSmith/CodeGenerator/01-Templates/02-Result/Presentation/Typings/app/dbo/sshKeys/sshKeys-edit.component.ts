﻿import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { SshKeysViewModel } from './model/sshKeys-view-model';

/**
 * 编辑
 */
@Component({
    selector: 'sshKeys-edit',
    templateUrl: env.prod() ? './html/sshKeys-edit.component.html' : '/view/dbo/sshKeys/edit'
})
export class SshKeysEditComponent extends EditComponentBase<SshKeysViewModel> {
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
        return new SshKeysViewModel();
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "sshKeys";
    }
}