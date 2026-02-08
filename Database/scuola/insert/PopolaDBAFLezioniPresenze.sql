SET NOCOUNT ON;

BEGIN TRY
    BEGIN TRAN;

    DECLARE @Now DATETIME = GETDATE();
    DECLARE @Today DATE = CAST(@Now AS DATE);

    DECLARE @CorsiScelti TABLE (CorsoId INT NOT NULL PRIMARY KEY);

    INSERT INTO @CorsiScelti (CorsoId)
    SELECT TOP (3) Id
    FROM dbo.Corsi
    ORDER BY Id DESC;

    -- Ora ci basta salvare solo LezioneId (e magari DocentiCorsiId se vuoi debug)
    DECLARE @LezioniInserite TABLE
    (
        LezioneId INT NOT NULL PRIMARY KEY,
        DocentiCorsiId INT NOT NULL
    );

    ;WITH N AS
    (
        SELECT TOP (5) ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS LezN
        FROM sys.all_objects
    ),
    Base AS
    (
        SELECT
            c.CorsoId,
            co.DataInizio,
            DocentiCorsiId =
                (SELECT TOP (1) dc.Id
                 FROM dbo.DocentiCorsi dc
                 WHERE dc.CorsoId = c.CorsoId
                 ORDER BY dc.IsDocentePrincipale DESC, dc.Id ASC)
        FROM @CorsiScelti c
        JOIN dbo.Corsi co ON co.Id = c.CorsoId
    )
    INSERT INTO dbo.Lezioni
    (
        DocentiCorsiId,
        Data,
        Argomento,
        Ufc,
        OrarioInizio,
        OrarioFine,
        Sede,
        Test
    )
    OUTPUT inserted.Id, inserted.DocentiCorsiId
      INTO @LezioniInserite (LezioneId, DocentiCorsiId)
    SELECT
        b.DocentiCorsiId,
        DATEADD(DAY, (n.LezN - 1) * 7, CAST(b.DataInizio AS DATE)),
        CASE n.LezN
            WHEN 1 THEN N'Introduzione e obiettivi'
            WHEN 2 THEN N'Fondamenti'
            WHEN 3 THEN N'Esercitazione guidata'
            WHEN 4 THEN N'Approfondimenti'
            ELSE        N'Ripasso e verifica'
        END,
        CONCAT(N'UFC', RIGHT(CONCAT('0', n.LezN), 2)),
        CAST('09:00' AS TIME),
        CAST('13:00' AS TIME),
        N'Aula 1',
        CASE WHEN n.LezN = 5 THEN 1 ELSE 0 END
    FROM Base b
    CROSS JOIN N n
    WHERE b.DocentiCorsiId IS NOT NULL;

    INSERT INTO dbo.Presenze
    (
        IscrizioneId,
        LezioneId,
        OrePresenza,
        EntraAlle,
        EsceAlle
    )
    SELECT
        i.Id AS IscrizioneId,
        l.LezioneId,
        CASE WHEN ABS(CHECKSUM(NEWID())) % 10 < 2 THEN 0 ELSE 4 END AS OrePresenza,
        CASE WHEN ABS(CHECKSUM(NEWID())) % 10 < 2 THEN NULL ELSE CAST('09:00' AS TIME) END AS EntraAlle,
        CASE WHEN ABS(CHECKSUM(NEWID())) % 10 < 2 THEN NULL ELSE CAST('13:00' AS TIME) END AS EsceAlle
    FROM @LezioniInserite l
    JOIN dbo.Lezioni lez
      ON lez.Id = l.LezioneId
    JOIN dbo.DocentiCorsi dc
      ON dc.Id = lez.DocentiCorsiId
    JOIN dbo.Iscrizioni i
      ON i.CorsoId = dc.CorsoId;

    COMMIT;

END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0 ROLLBACK;
    THROW;
END CATCH;
