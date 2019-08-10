import { QueryParameter } from '../../../../util';

/**
 * 查询参数
 */
export class TeamsQuery extends QueryParameter {
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
}