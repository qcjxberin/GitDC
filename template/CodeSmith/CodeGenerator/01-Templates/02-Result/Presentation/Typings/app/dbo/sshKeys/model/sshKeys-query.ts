import { QueryParameter } from '../../../../util';

/**
 * 查询参数
 */
export class SshKeysQuery extends QueryParameter {
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
    keyType;
    /**
     * 
     */
    fingerprint;
    /**
     * 
     */
    publicKey;
    /**
     * 起始
     */
    beginImportData;
    /**
     * 结束
     */
    endImportData;
    /**
     * 起始
     */
    beginLastUse;
    /**
     * 结束
     */
    endLastUse;
}