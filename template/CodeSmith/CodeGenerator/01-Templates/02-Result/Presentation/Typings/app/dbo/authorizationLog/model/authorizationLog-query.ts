import { QueryParameter } from '../../../../util';

/**
 * 查询参数
 */
export class AuthorizationLogQuery extends QueryParameter {
    /**
     * 
     */
    authCode;
    /**
     * 
     */
    userID;
    /**
     * 起始
     */
    beginIssueDate;
    /**
     * 结束
     */
    endIssueDate;
    /**
     * 起始
     */
    beginExpires;
    /**
     * 结束
     */
    endExpires;
    /**
     * 
     */
    issueIp;
    /**
     * 
     */
    lastIp;
    /**
     * 
     */
    isValid;
}