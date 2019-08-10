import { ViewModel } from '../../../../util';

/**
 * 用户名视图模型
 */
export class UsersViewModel extends ViewModel {
    /**
     * 用户名
     */
    name;
    /**
     * 昵称
     */
    nickName;
    /**
     * 邮箱
     */
    email;
    /**
     * 密码版本
     */
    passwordVersion;
    /**
     * 密码
     */
    password;
    /**
     * 描述
     */
    description;
    /**
     * 是否系统管理员
     */
    isSystemAdministrator;
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