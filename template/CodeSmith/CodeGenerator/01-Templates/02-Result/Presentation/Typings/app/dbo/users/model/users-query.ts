import { QueryParameter } from '../../../../util';

/**
 * 用户名查询参数
 */
export class UsersQuery extends QueryParameter {
    /**
     * 编号
     */
    id;
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