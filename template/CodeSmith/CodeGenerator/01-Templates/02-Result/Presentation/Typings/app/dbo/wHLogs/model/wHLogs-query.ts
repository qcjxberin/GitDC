import { QueryParameter } from '../../../../util';

/**
 * 网络勾子推送内容日志查询参数
 */
export class WHLogsQuery extends QueryParameter {
    /**
     * 编号
     */
    id;
    /**
     * 是为中转，否为非中转
     */
    wHTypes;
    /**
     * 请求头部
     */
    requestTop;
    /**
     * 推送内容
     */
    content;
    /**
     * 响应头部
     */
    responseTop;
    /**
     * 响应内容
     */
    responseContent;
    /**
     * 响应结果
     */
    responseBody;
    /**
     * 起始创建时间
     */
    beginCreationTime;
    /**
     * 结束创建时间
     */
    endCreationTime;
}