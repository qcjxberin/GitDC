import { QueryParameter } from '../../../../util';

/**
 * 查询参数
 */
export class UserRepositoryRoleQuery extends QueryParameter {
    /**
     * 
     */
    id;
    /**
     * 
     */
    userID;
    /**
     * 
     */
    repositoryID;
    /**
     * 
     */
    allowRead;
    /**
     * 
     */
    allowWrite;
    /**
     * 
     */
    isOwner;
}