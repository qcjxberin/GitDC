import { QueryParameter } from '../../../../util';

/**
 * 仓库表查询参数
 */
export class RepositoriesQuery extends QueryParameter {
    /**
     * 编号
     */
    id;
    /**
     * 默认分支
     */
    defaultBranch;
    /**
     * 描述
     */
    description;
    /**
     * 是否镜像
     */
    isMirror;
    /**
     * 是否私人
     */
    isPrivate;
    /**
     * 项目名称
     */
    name;
    /**
     * 问题数量
     */
    numIssues;
    /**
     * 未关闭的问题数量
     */
    numOpenIssues;
    /**
     * 未关闭的合并请求数量
     */
    numOpenPulls;
    /**
     * 合并请求数量
     */
    numPulls;
    /**
     * 大小
     */
    size;
    /**
     * 归属用户
     */
    userID;
    /**
     * 用户名称
     */
    userName;
    /**
     * 起始创建时间
     */
    beginCreationTime;
    /**
     * 结束创建时间
     */
    endCreationTime;
    /**
     * 起始最后修改时间
     */
    beginLastModifiTime;
    /**
     * 结束最后修改时间
     */
    endLastModifiTime;
}