SET NOCOUNT ON;

BEGIN TRY
    BEGIN TRAN;

    DECLARE @Now DATETIME = GETDATE();
    DECLARE @Today DATE = CAST(@Now AS DATE);
    DECLARE @StartId INT = ISNULL((SELECT MAX(Id) FROM dbo.Anagrafiche), 0);

    DECLARE @Nomi TABLE (Id INT NOT NULL PRIMARY KEY, Nome NVARCHAR(100) NOT NULL, Sesso NVARCHAR(20) NOT NULL);
    INSERT INTO @Nomi (Id, Nome, Sesso) VALUES
    (1,N'Mario',N'M'),(2,N'Luca',N'M'),(3,N'Marco',N'M'),(4,N'Andrea',N'M'),(5,N'Giuseppe',N'M'),
    (6,N'Francesco',N'M'),(7,N'Paolo',N'M'),(8,N'Antonio',N'M'),(9,N'Stefano',N'M'),(10,N'Roberto',N'M'),
    (11,N'Federico',N'M'),(12,N'Alessandro',N'M'),(13,N'Matteo',N'M'),(14,N'Davide',N'M'),(15,N'Simone',N'M'),
    (16,N'Nicola',N'M'),(17,N'Giorgio',N'M'),(18,N'Enrico',N'M'),(19,N'Fabio',N'M'),(20,N'Michele',N'M'),
    (21,N'Riccardo',N'M'),(22,N'Tommaso',N'M'),(23,N'Pietro',N'M'),(24,N'Filippo',N'M'),(25,N'Edoardo',N'M'),
    (26,N'Gabriele',N'M'),(27,N'Leonardo',N'M'),(28,N'Cristiano',N'M'),(29,N'Salvatore',N'M'),(30,N'Vincenzo',N'M'),
    (31,N'Domenico',N'M'),(32,N'Giovanni',N'M'),(33,N'Claudio',N'M'),(34,N'Maurizio',N'M'),(35,N'Sergio',N'M'),
    (36,N'Alberto',N'M'),(37,N'Emilio',N'M'),(38,N'Carlo',N'M'),(39,N'Piero',N'M'),(40,N'Raffaele',N'M'),
    (41,N'Giulio',N'M'),(42,N'Cesare',N'M'),(43,N'Giacomo',N'M'),(44,N'Umberto',N'M'),(45,N'Angelo',N'M'),
    (46,N'Giulia',N'F'),(47,N'Martina',N'F'),(48,N'Francesca',N'F'),(49,N'Sara',N'F'),(50,N'Chiara',N'F'),
    (51,N'Elena',N'F'),(52,N'Valentina',N'F'),(53,N'Laura',N'F'),(54,N'Anna',N'F'),(55,N'Alessia',N'F'),
    (56,N'Federica',N'F'),(57,N'Claudia',N'F'),(58,N'Beatrice',N'F'),(59,N'Silvia',N'F'),(60,N'Lucia',N'F'),
    (61,N'Elisa',N'F'),(62,N'Giorgia',N'F'),(63,N'Ilaria',N'F'),(64,N'Monica',N'F'),(65,N'Roberta',N'F'),
    (66,N'Noemi',N'F'),(67,N'Arianna',N'F'),(68,N'Camilla',N'F'),(69,N'Greta',N'F'),(70,N'Cristina',N'F'),
    (71,N'Paola',N'F'),(72,N'Rita',N'F'),(73,N'Angela',N'F'),(74,N'Patrizia',N'F'),(75,N'Stefania',N'F'),
    (76,N'Margherita',N'F'),(77,N'Nicole',N'F'),(78,N'Veronica',N'F'),(79,N'Marianna',N'F'),(80,N'Debora',N'F'),
    (81,N'Bianca',N'F'),(82,N'Gaia',N'F'),(83,N'Linda',N'F'),(84,N'Vittoria',N'F'),(85,N'Rachele',N'F'),
    (86,N'Emma',N'F'),(87,N'Viola',N'F'),(88,N'Aurora',N'F'),(89,N'Sofia',N'F'),(90,N'Carla',N'F'),
    (91,N'Elvira',N'F'),(92,N'Anita',N'F'),(93,N'Livia',N'F'),(94,N'Serena',N'F'),(95,N'Barbara',N'F'),
    (96,N'Daniela',N'F'),(97,N'Matilde',N'F'),(98,N'Giada',N'F'),(99,N'Virginia',N'F'),(100,N'Lucrezia',N'F');

    DECLARE @Cognomi TABLE (Id INT NOT NULL PRIMARY KEY, Cognome NVARCHAR(100) NOT NULL);
    INSERT INTO @Cognomi (Id, Cognome) VALUES
    (1,N'Rossi'),(2,N'Russo'),(3,N'Ferrari'),(4,N'Esposito'),(5,N'Bianchi'),
    (6,N'Romano'),(7,N'Colombo'),(8,N'Ricci'),(9,N'Marino'),(10,N'Greco'),
    (11,N'Bruno'),(12,N'Gallo'),(13,N'Conti'),(14,N'De Luca'),(15,N'Mancini'),
    (16,N'Costa'),(17,N'Giordano'),(18,N'Rizzo'),(19,N'Lombardi'),(20,N'Barbieri'),
    (21,N'Moretti'),(22,N'Fontana'),(23,N'Santoro'),(24,N'Caruso'),(25,N'Ferrara'),
    (26,N'Fabbri'),(27,N'Longo'),(28,N'Serra'),(29,N'Gatti'),(30,N'Vitale'),
    (31,N'Rinaldi'),(32,N'Leone'),(33,N'Martini'),(34,N'De Santis'),(35,N'D''Angelo'),
    (36,N'Villa'),(37,N'Bernardi'),(38,N'Marchetti'),(39,N'Pellegrini'),(40,N'Ferri'),
    (41,N'Bartoli'),(42,N'Graziani'),(43,N'Parisi'),(44,N'Ferraro'),(45,N'Valentini'),
    (46,N'Riva'),(47,N'Palmieri'),(48,N'Fiorentino'),(49,N'Testa'),(50,N'Ruggiero'),
    (51,N'Benedetti'),(52,N'Catalano'),(53,N'Monti'),(54,N'Negri'),(55,N'Piras'),
    (56,N'Farina'),(57,N'Basile'),(58,N'Sala'),(59,N'Amato'),(60,N'Pace'),
    (61,N'Orlando'),(62,N'Bellini'),(63,N'Puglisi'),(64,N'Grassi'),(65,N'Guidi'),
    (66,N'Neri'),(67,N'Borrelli'),(68,N'Fusco'),(69,N'Pagano'),(70,N'Guerra'),
    (71,N'Vitali'),(72,N'Rocca'),(73,N'Carli'),(74,N'Fiore'),(75,N'Pastore'),
    (76,N'Bettini'),(77,N'Meli'),(78,N'Angelini'),(79,N'Spinelli'),(80,N'Donati'),
    (81,N'Caputo'),(82,N'Bianco'),(83,N'Poli'),(84,N'Gori'),(85,N'Sarti'),
    (86,N'Di Stefano'),(87,N'Romagnoli'),(88,N'Mazza'),(89,N'Furlan'),(90,N'Baldini'),
    (91,N'Terranova'),(92,N'Fornari'),(93,N'Salvatori'),(94,N'Gentile'),(95,N'Messina'),
    (96,N'Ramos'),(97,N'Ruggeri'),(98,N'Gambino'),(99,N'Petrini'),(100,N'Mazzucchelli');

    ;WITH Tally AS
    (
        SELECT TOP (100) ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS N
        FROM sys.all_objects
    )
    INSERT INTO dbo.Anagrafiche
    (
        Nome, Cognome, CodiceFiscale, DataNascita,
        IndirizzoResidenza, CittaResidenza,
        NumeroTelefono, Email, Pec, Sesso
    )
    SELECT
        n.Nome,
        c.Cognome,
        UPPER(CONCAT(
            LEFT(REPLACE(c.Cognome, N' ', N''), 3),
            LEFT(REPLACE(n.Nome, N' ', N''), 2),
            RIGHT(CONVERT(VARCHAR(8),
                CASE WHEN t.N <= 10
                     THEN DATEADD(YEAR, -(30 + (ABS(CHECKSUM(NEWID())) % 36)), @Today)
                     ELSE DATEADD(YEAR, -(16 + (ABS(CHECKSUM(NEWID())) % 15)), @Today)
                END, 112), 6),
            RIGHT(CONCAT('0', t.N), 2),
            CHAR(65 + (ABS(CHECKSUM(NEWID())) % 26))
        )),
        CASE
            WHEN t.N <= 10 THEN DATEADD(DAY, -(ABS(CHECKSUM(NEWID())) % 365),
                                 DATEADD(YEAR, -(30 + (ABS(CHECKSUM(NEWID())) % 36)), @Today))
            ELSE DATEADD(DAY, -(ABS(CHECKSUM(NEWID())) % 365),
                                 DATEADD(YEAR, -(16 + (ABS(CHECKSUM(NEWID())) % 15)), @Today))
        END,
        CONCAT(
            CASE (t.N % 12)
                WHEN 0 THEN N'Via Roma'
                WHEN 1 THEN N'Via Garibaldi'
                WHEN 2 THEN N'Via Dante Alighieri'
                WHEN 3 THEN N'Viale Europa'
                WHEN 4 THEN N'Via delle Rose'
                WHEN 5 THEN N'Via dei Tigli'
                WHEN 6 THEN N'Corso Vannucci'
                WHEN 7 THEN N'Via dei Priori'
                WHEN 8 THEN N'Via XX Settembre'
                WHEN 9 THEN N'Via Trasimeno'
                WHEN 10 THEN N'Via della Libertà'
                ELSE N'Piazza Matteotti'
            END,
            N' ', 1 + (ABS(CHECKSUM(NEWID())) % 180), N', Int. ', 1 + (ABS(CHECKSUM(NEWID())) % 12)
        ),
        CASE (t.N % 10)
            WHEN 0 THEN N'Perugia'
            WHEN 1 THEN N'Foligno'
            WHEN 2 THEN N'Terni'
            WHEN 3 THEN N'Assisi'
            WHEN 4 THEN N'Spoleto'
            WHEN 5 THEN N'Gubbio'
            WHEN 6 THEN N'Città di Castello'
            WHEN 7 THEN N'Roma'
            WHEN 8 THEN N'Firenze'
            ELSE N'Bologna'
        END,
        CONCAT(N'+39 3', 20 + (t.N % 79), N' ', RIGHT(CONCAT('0000000', 1000000 + t.N * 7919), 7)),
        CONCAT(LOWER(REPLACE(REPLACE(n.Nome, N' ', N''), N'''', N'')), N'.', LOWER(REPLACE(REPLACE(c.Cognome, N' ', N''), N'''', N'')), RIGHT(CONCAT('00', t.N), 2), N'@example.it'),
        CONCAT(LOWER(REPLACE(REPLACE(n.Nome, N' ', N''), N'''', N'')), N'.', LOWER(REPLACE(REPLACE(c.Cognome, N' ', N''), N'''', N'')), RIGHT(CONCAT('00', t.N), 2), N'@pec.example.it'),
        n.Sesso
    FROM Tally t
    JOIN @Nomi n ON n.Id = t.N
    JOIN @Cognomi c ON c.Id = t.N
    ORDER BY t.N;

    INSERT INTO dbo.Docenti (AnagraficaId, StatoCollaborazione, DataAssunzione, DataInserimento, Categoria)
    SELECT TOP (10)
        a.Id,
        CASE WHEN a.Id % 3 = 0 THEN 2 ELSE 1 END,
        DATEADD(DAY, -(ABS(CHECKSUM(NEWID())) % 5000), @Today),
        @Now,
        CASE WHEN a.Id % 2 = 0 THEN N'Docente Senior' ELSE N'Docente Junior' END
    FROM dbo.Anagrafiche a
    WHERE a.Id > @StartId
    ORDER BY a.Id;

    INSERT INTO dbo.Studenti (AnagraficaId, Matricola, DataInserimento, StatoOccupazionale)
    SELECT
        a.Id,
        CONCAT(N'S', FORMAT(ROW_NUMBER() OVER (ORDER BY a.Id), '00000')),
        @Now,
        CASE (ABS(CHECKSUM(NEWID())) % 4) WHEN 0 THEN 2 WHEN 1 THEN 1 WHEN 2 THEN 3 ELSE 0 END
    FROM dbo.Anagrafiche a
    WHERE a.Id > @StartId
      AND a.Id NOT IN (SELECT d.AnagraficaId FROM dbo.Docenti d);

    COMMIT;

END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0 ROLLBACK;
    THROW;
END CATCH;
