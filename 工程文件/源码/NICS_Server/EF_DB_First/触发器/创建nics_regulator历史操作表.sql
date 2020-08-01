DROP TABLE
IF EXISTS nics_regulator_history;

CREATE TABLE nics_regulator_history (
	id BIGINT (20) NOT NULL AUTO_INCREMENT,
	nics_regulator_id BIGINT (20) NOT NULL COMMENT 'nics_regulator�������ID',
	client_id BIGINT (20) NOT NULL COMMENT 'nics_regulator��ͻ���ID',
	operate_type VARCHAR (200) NOT NULL COMMENT 'nics_regulator����������ͣ����� ���� ɾ��',
	operate_time datetime NOT NULL COMMENT 'nics_regulator�������ʱ��',
	is_operate VARCHAR (200) NOT NULL COMMENT '����������Ƿ���й����� 0��ʾû�д��� 1�����',
	PRIMARY KEY (`id`)
) ENGINE = MyISAM DEFAULT CHARSET = utf8;