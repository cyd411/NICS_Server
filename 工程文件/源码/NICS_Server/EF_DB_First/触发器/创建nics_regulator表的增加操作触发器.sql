DROP TRIGGER
IF EXISTS tri_insert_nics_regulator;

CREATE TRIGGER tri_insert_nics_regulator AFTER INSERT ON nics_regulator FOR EACH ROW
BEGIN
	INSERT INTO nics_regulator_history (
		nics_regulator_id,
		client_id,
		operate_type,
		operate_time,
		is_operate
	)
VALUES
	(
		new.id,
		new.client_id,
		'add',
		now(),
		'0'
	);


END;