import { QueryParameter } from '../../../../util';

/**
 * 查询参数
 */
export class RepositoriesQuery extends QueryParameter {
    /**
     * 
     */
    id;
    /**
     * 
     */
    name;
    /**
     * 
     */
    description;
    /**
     * 起始
     */
    beginCreationDate;
    /**
     * 结束
     */
    endCreationDate;
    /**
     * 
     */
    isPrivate;
    /**
     * 
     */
    allowAnonymousRead;
    /**
     * 
     */
    allowAnonymousWrite;
}