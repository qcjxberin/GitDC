using System;
using GitDC.Domains.Models;

namespace GitDC.Domains.Factories {
    /// <summary>
    /// 工厂
    /// </summary>
    public static class SshKeysFactory {
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userID"></param>
        /// <param name="keyType"></param>
        /// <param name="fingerprint"></param>
        /// <param name="publicKey"></param>
        /// <param name="importData"></param>
        /// <param name="lastUse"></param>
        public static SshKeys Create( 
            long id,
            long userID,
            string keyType,
            string fingerprint,
            string publicKey,
            DateTime importData,
            DateTime lastUse
        ) {
            SshKeys result;
            result = new SshKeys( id );
            result.UserID = userID;
            result.KeyType = keyType;
            result.Fingerprint = fingerprint;
            result.PublicKey = publicKey;
            result.ImportData = importData;
            result.LastUse = lastUse;
            return result;
        }
    }
}