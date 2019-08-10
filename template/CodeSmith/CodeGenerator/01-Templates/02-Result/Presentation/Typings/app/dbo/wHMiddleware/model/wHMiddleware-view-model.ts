import { ViewModel } from '../../../../util';

/**
 * 网络勾子中转表视图模型
 */
export class WHMiddlewareViewModel extends ViewModel {
    /**
     * 令牌
     */
    token;
    /**
     * 1.腾讯云开发者中心项目
     */
    source;
    /**
     * 1.钉钉
     */
    push;
    /**
     * 推送Url
     */
    pushUrl;
    /**
     * 推送令牌
     */
    pushToken;
    /**
     * 创建时间
     */
    creationTime;
    /**
     * 创建人编号
     */
    creatId;
    /**
     * 最后修改时间
     */
    lastModifiTime;
    /**
     * 最后修改人编号
     */
    lastModifiId;
    /**
     * 软删除，数据不会被物理删除
     */
    isDeleted;
    /**
     * 处理并发问题
     */
    version;
}