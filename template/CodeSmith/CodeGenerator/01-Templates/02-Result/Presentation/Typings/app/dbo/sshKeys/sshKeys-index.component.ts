import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { SshKeysQuery } from './model/sshKeys-query';
import { SshKeysViewModel } from './model/sshKeys-view-model';

/**
 * 首页
 */
@Component({
    selector: 'sshKeys-index',
    templateUrl: env.prod() ? './html/sshKeys-index.component.html' : '/view/dbo/sshKeys'
})
export class SshKeysIndexComponent extends TableQueryComponentBase<SshKeysViewModel, SshKeysQuery>  {
    /**
     * 初始化首页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }
    
    /**
     * 创建查询参数
     */
    protected createQuery() {
        return new SshKeysQuery();
    }
}