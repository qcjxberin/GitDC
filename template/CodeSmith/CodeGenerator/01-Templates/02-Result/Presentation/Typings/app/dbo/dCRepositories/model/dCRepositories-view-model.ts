import { ViewModel } from '../../../../util';

/**
 * 仓库表视图模型
 */
export class DCRepositoriesViewModel extends ViewModel {
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
     * 创建时间
     */
    creationTime;
    /**
     * 最后修改时间
     */
    lastModifiTime;
    /**
     * 软删除，数据不会被物理删除
     */
    isDeleted;
    /**
     * 处理并发问题
     */
    version;
}