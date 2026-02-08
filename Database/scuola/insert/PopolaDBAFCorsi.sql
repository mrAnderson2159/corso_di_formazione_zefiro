SET NOCOUNT ON;

BEGIN TRY
    BEGIN TRAN;

    DECLARE @Now DATETIME = GETDATE();
    DECLARE @Today DATE = CAST(@Now AS DATE);

    DECLARE @StartCorsoId INT = ISNULL((SELECT MAX(Id) FROM dbo.Corsi), 0);

    ;WITH Tally AS
    (
        SELECT TOP (10) ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS N
        FROM sys.all_objects
    )
    INSERT INTO dbo.Corsi
    (
        Titolo,
        TotaleOre,
        Finanziato,
        EnteFinanziatore,
        DataInizio,
        DataFine,
        DataEsame,
        ModalitaErogazione
    )
    SELECT
        CASE N
            WHEN 1 THEN N'Introduzione a SQL Server'
            WHEN 2 THEN N'Fondamenti di C# e .NET'
            WHEN 3 THEN N'Entity Framework Core - Base'
            WHEN 4 THEN N'Web API con ASP.NET Core'
            WHEN 5 THEN N'Angular - Fondamenti'
            WHEN 6 THEN N'Git e lavoro in team'
            WHEN 7 THEN N'Database Design e Normalizzazione'
            WHEN 8 THEN N'Testing: Unit e Integration'
            WHEN 9 THEN N'Cloud Basics (Azure)'
            ELSE        N'AI Generativa - Introduzione'
        END,
        CASE N
            WHEN 1 THEN 24 WHEN 2 THEN 32 WHEN 3 THEN 28 WHEN 4 THEN 30 WHEN 5 THEN 36
            WHEN 6 THEN 16 WHEN 7 THEN 20 WHEN 8 THEN 18 WHEN 9 THEN 14 ELSE 22 END,
        CASE WHEN N % 2 = 0 THEN 1 ELSE 0 END,
        CASE WHEN N % 2 = 0 THEN N'Regione Umbria' ELSE NULL END,
        DATEADD(DAY, 7 * (N - 1), @Today),
        DATEADD(DAY, 7 * (N - 1) + 20, @Today),
        DATEADD(DAY, 7 * (N - 1) + 27, @Today),
        CASE WHEN N % 3 = 0 THEN 2 WHEN N % 3 = 1 THEN 1 ELSE 3 END
    FROM Tally;

    DECLARE @CourseMap TABLE (N INT NOT NULL PRIMARY KEY, CorsoId INT NOT NULL);

    ;WITH NewCorsi AS
    (
        SELECT Id, ROW_NUMBER() OVER (ORDER BY Id) AS N
        FROM dbo.Corsi
        WHERE Id > @StartCorsoId
    )
    INSERT INTO @CourseMap (N, CorsoId)
    SELECT N, Id
    FROM NewCorsi;

    ;WITH DocList AS
    (
        SELECT d.Id AS DocenteId
        FROM dbo.Docenti d
    )
    INSERT INTO dbo.DocentiCorsi
    (
        DocenteId,
        CorsoId,
        TotaleOrePreviste,
        TotaleOreEffettuate,
        IsDocentePrincipale
    )
    SELECT
        x.DocenteId,
        c.CorsoId,
        CAST(6 + (c.N % 4) AS INT),
        CAST(5 + (c.N % 3) AS INT),
        CASE WHEN x.Pick = 1 THEN 1 ELSE 0 END
    FROM @CourseMap c
    CROSS APPLY
    (
        SELECT TOP (3)
            d.DocenteId,
            ROW_NUMBER() OVER (ORDER BY ABS(CHECKSUM(d.DocenteId, c.N))) AS Pick
        FROM DocList d
        ORDER BY ABS(CHECKSUM(d.DocenteId, c.N))
    ) x;

    ;WITH S AS
    (
        SELECT s.Id AS StudenteId, ROW_NUMBER() OVER (ORDER BY s.Id) AS rn
        FROM dbo.Studenti s
    ),
    Assign AS
    (
        SELECT
            StudenteId,
            CourseN = ((rn - 1) / 9) + 1,
            PosInCourse = ((rn - 1) % 9) + 1
        FROM S
        WHERE rn <= 90
    )
    INSERT INTO dbo.Iscrizioni
    (
        StudenteId,
        CorsoId,
        DataIscrizione,
        Ritirato,
        DataRitiro,
        CostoIscrizione
    )
    SELECT
        a.StudenteId,
        cm.CorsoId,
        DATEADD(DAY, - (a.PosInCourse % 7), @Today),
        0,
        NULL,
        CAST(150 + (cm.N * 25) AS DECIMAL(10,2))
    FROM Assign a
    JOIN @CourseMap cm ON cm.N = a.CourseN;

    COMMIT;

END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0 ROLLBACK;
    THROW;
END CATCH;
