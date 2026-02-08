BEGIN tran;

ALTER TABLE DocentiCorsi ADD CONSTRAINT UQ_DocentiCorsi UNIQUE(DocenteId, CorsoId);
ALTER TABLE Iscrizioni ADD CONSTRAINT UQ_Iscrizioni UNIQUE(StudenteId, CorsoId);
ALTER TABLE Lezioni DROP CONSTRAINT FK__Lezioni__CorsoId__5DCAEF64;
ALTER TABLE Lezioni DROP COLUMN CorsoId;
ALTER TABLE Lezioni ALTER COLUMN OrarioInizio time NOT NULL;
ALTER TABLE Lezioni ALTER COLUMN OrarioFine time NOT NULL;
ALTER TABLE Lezioni ADD CONSTRAINT UQ_Lezioni UNIQUE(DocentiCorsiId, [Data], OrarioInizio, OrarioFine);
ALTER TABLE Lezioni ADD CONSTRAINT CK_Lezioni_Orari CHECK (OrarioFine > OrarioInizio);
ALTER TABLE Presenze ADD CONSTRAINT UQ_Presenze UNIQUE(IscrizioneId, LezioneId);

COMMIT;