DROP TABLE
IF EXISTS nics_regulator_history;

CREATE TABLE nics_regulator_history (
	id BIGINT (20) NOT NULL AUTO_INCREMENT,
	nics_regulator_id BIGINT (20) NOT NULL COMMENT 'nics_regulator表控制器ID',
	client_id BIGINT (20) NOT NULL COMMENT 'nics_regulator表客户端ID',
	operate_type VARCHAR (200) NOT NULL COMMENT 'nics_regulator表操作的类型，增加 更新 删除',
	operate_time datetime NOT NULL COMMENT 'nics_regulator表操作的时间',
	is_operate VARCHAR (200) NOT NULL COMMENT '服务器软件是否进行过处理 0表示没有处理 1处理过',
	PRIMARY KEY (`id`)
) ENGINE = MyISAM DEFAULT CHARSET = utf8;