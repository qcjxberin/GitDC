import { ViewModel } from '../../../../util';

/**
 * 网络勾子推送内容日志视图模型
 */
export class WHLogsViewModel extends ViewModel {
    /**
     * 是为中转，否为非中转
     */
    wHTypes;
    /**
     * 推送内容
     */
    content;
    /**
     * 创建人编号
     */
    creatId;
    /**
     * 创建时间
     */
    creationTime;
    /**
     * 软删除，数据不会被物理删除
     */
    isDeleted;
    /**
     * 处理并发问题
     */
    version;
}