--SELECT name
--FROM sys.foreign_keys
--WHERE parent_object_id = OBJECT_ID('Persone');

--ALTER TABLE Persone
--DROP CONSTRAINT FK_Persone_Sport;

ALTER TABLE Persone
ADD CONSTRAINT FK_Persone_Sport
FOREIGN KEY (IdSport)
REFERENCES Sport(Id)
ON DELETE SET NULL;