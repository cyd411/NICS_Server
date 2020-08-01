DROP TRIGGER
IF EXISTS tri_delete_nics_regulator;

CREATE TRIGGER tri_delete_nics_regulator AFTER DELETE ON nics_regulator FOR EACH ROW
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
		old.id,
		old.client_id,
		'delete',
		now(),
		'0'
	);


END;