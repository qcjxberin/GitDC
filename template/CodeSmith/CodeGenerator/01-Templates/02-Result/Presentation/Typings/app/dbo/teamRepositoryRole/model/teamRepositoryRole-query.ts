import { QueryParameter } from '../../../../util';

/**
 * 查询参数
 */
export class TeamRepositoryRoleQuery extends QueryParameter {
    /**
     * 
     */
    id;
    /**
     * 
     */
    teamID;
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
}