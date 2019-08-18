SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for dc_repositories
-- ----------------------------
DROP TABLE IF EXISTS `dc_repositories`;
CREATE TABLE `dc_repositories`  (
  `Id` char(36) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '编号',
  `DefaultBranch` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '默认分支',
  `Description` varchar(512) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '描述',
  `IsMirror` tinyint(1) NULL DEFAULT NULL COMMENT '是否镜像',
  `IsPrivate` tinyint(1) NULL DEFAULT NULL COMMENT '是否私人',
  `Name` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '项目名称',
  `NumIssues` int(11) NULL DEFAULT NULL COMMENT '问题数量',
  `NumOpenIssues` int(11) NULL DEFAULT NULL COMMENT '未关闭的问题数量',
  `NumOpenPulls` int(11) NULL DEFAULT NULL COMMENT '未关闭的合并请求数量',
  `NumPulls` int(11) NULL DEFAULT NULL COMMENT '合并请求数量',
  `Size` decimal(32, 10) NULL DEFAULT NULL COMMENT '大小',
  `UserID` bigint(20) NULL DEFAULT NULL COMMENT '归属用户',
  `UserName` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '用户名称',
  `CreationTime` datetime(0) NULL DEFAULT NULL COMMENT '创建时间',
  `LastModifiTime` datetime(0) NULL DEFAULT NULL COMMENT '最后修改时间',
  `IsDeleted` tinyint(1) NOT NULL COMMENT '是否删除 软删除，数据不会被物理删除',
  `Version` tinyblob NULL COMMENT '乐观锁 处理并发问题',
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci COMMENT = '仓库表 ' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of dc_repositories
-- ----------------------------

-- ----------------------------
-- Table structure for dc_users
-- ----------------------------
DROP TABLE IF EXISTS `dc_users`;
CREATE TABLE `dc_users`  (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '编号',
  `Name` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '用户名',
  `NickName` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '昵称',
  `Email` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '邮箱',
  `PasswordVersion` smallint(6) NULL DEFAULT NULL COMMENT '密码版本',
  `Password` varchar(32) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '密码',
  `Salt` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '盐值',
  `Description` varchar(500) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '描述',
  `IsSystemAdministrator` tinyint(1) NULL DEFAULT NULL COMMENT '是否系统管理员',
  `CreationTime` datetime(0) NULL DEFAULT NULL COMMENT '创建时间',
  `CreatId` int(11) NULL DEFAULT NULL COMMENT '创建人编号',
  `LastModifiTime` datetime(0) NULL DEFAULT NULL COMMENT '最后修改时间',
  `LastModifiId` int(11) NULL DEFAULT NULL COMMENT '最后修改人编号',
  `IsDeleted` tinyint(1) NOT NULL COMMENT '是否删除 软删除，数据不会被物理删除',
  `Version` tinyblob NULL COMMENT '乐观锁 处理并发问题',
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8 COLLATE = utf8_general_ci COMMENT = '用户名 ' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of dc_users
-- ----------------------------
INSERT INTO `dc_users` VALUES (1, 'admin', 'admin', '2505111990@qq.com', 1, '0377c3b557f26e6456468aea4c04e50a', 'asdfew', 'System administrator', 1, '2019-08-10 15:21:49', 1, NULL, NULL, 0, 0x61656534376162362D613665392D343434322D386665662D653232303430663863326333);

-- ----------------------------
-- Table structure for wh_logs
-- ----------------------------
DROP TABLE IF EXISTS `wh_logs`;
CREATE TABLE `wh_logs`  (
  `Id` char(36) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '编号',
  `WhId` varchar(36) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '勾子编号',
  `WHTypes` tinyint(1) NOT NULL COMMENT '类型;是为中转，否为非中转',
  `RequestTop` varchar(2000) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '请求头部',
  `Content` text CHARACTER SET utf8 COLLATE utf8_general_ci NULL COMMENT '推送内容',
  `ResponseTop` varchar(2000) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '响应头部',
  `ResponseContent` text CHARACTER SET utf8 COLLATE utf8_general_ci NULL COMMENT '响应内容',
  `ResponseBody` varchar(2000) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '响应结果',
  `CreationTime` datetime(0) NULL DEFAULT NULL COMMENT '创建时间',
  `IsDeleted` tinyint(1) NOT NULL COMMENT '是否删除;软删除，数据不会被物理删除',
  `Version` tinyblob NULL COMMENT '乐观锁;处理并发问题',
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci COMMENT = '网络勾子推送内容日志;' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of wh_logs
-- ----------------------------

-- ----------------------------
-- Table structure for wh_middleware
-- ----------------------------
DROP TABLE IF EXISTS `wh_middleware`;
CREATE TABLE `wh_middleware`  (
  `Id` char(36) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '编号',
  `Name` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '名称',
  `Summary` varchar(500) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '介绍',
  `Token` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '令牌',
  `Source` smallint(6) NOT NULL COMMENT '来源',
  `Push` smallint(6) NOT NULL COMMENT '推送',
  `PushUrl` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL COMMENT '推送Url',
  `PushToken` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '推送令牌',
  `CreationTime` datetime(0) NULL DEFAULT NULL COMMENT '创建时间',
  `CreatId` int(11) NULL DEFAULT NULL COMMENT '创建人编号',
  `LastModifiTime` datetime(0) NULL DEFAULT NULL COMMENT '最后修改时间',
  `LastModifiId` int(11) NULL DEFAULT NULL COMMENT '最后修改人编号',
  `IsDeleted` tinyint(1) NOT NULL COMMENT '是否删除;软删除，数据不会被物理删除',
  `Version` tinyblob NULL COMMENT '乐观锁;处理并发问题',
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci COMMENT = '网络勾子中转表;' ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of wh_middleware
-- ----------------------------

SET FOREIGN_KEY_CHECKS = 1;
