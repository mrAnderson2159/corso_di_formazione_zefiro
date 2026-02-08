
	SELECT fk.name FROM sys.foreign_keys fk
	WHERE fk.parent_object_id = OBJECT_ID('dbo.Lezioni');