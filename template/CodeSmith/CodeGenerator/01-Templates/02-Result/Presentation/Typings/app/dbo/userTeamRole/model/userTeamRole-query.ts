import { QueryParameter } from '../../../../util';

/**
 * 查询参数
 */
export class UserTeamRoleQuery extends QueryParameter {
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
    teamID;
    /**
     * 
     */
    isAdministrator;
}