import { QueryParameter } from '../../../../util';

/**
 * 网络勾子中转表查询参数
 */
export class WHMiddlewareQuery extends QueryParameter {
    /**
     * 编号
     */
    id;
    /**
     * 名称
     */
    name;
    /**
     * 介绍
     */
    summary;
    /**
     * 令牌
     */
    token;
    /**
     * 1.腾讯云开发者中心项目，2为禅道，3为码云，4为Gogs，5为Gitea
     */
    source;
    /**
     * 1.钉钉，2为企业微信
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
     * 起始创建时间
     */
    beginCreationTime;
    /**
     * 结束创建时间
     */
    endCreationTime;
    /**
     * 创建人编号
     */
    creatId;
    /**
     * 起始最后修改时间
     */
    beginLastModifiTime;
    /**
     * 结束最后修改时间
     */
    endLastModifiTime;
    /**
     * 最后修改人编号
     */
    lastModifiId;
}