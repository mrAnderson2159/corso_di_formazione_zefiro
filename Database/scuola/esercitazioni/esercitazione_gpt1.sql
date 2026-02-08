--========================================
--ESERCIZI SQL – DATABASE SCUOLA
--Progressione da facile a difficile
--========================================
--DB: SQL Server
--Schema: Anagrafiche, Studenti, Docenti, Corsi,
--        DocentiCorsi, Iscrizioni, Lezioni, Presenze
--========================================


--========================
--LIVELLO 1 – BASE
--========================

--1) Seleziona tutte le anagrafiche mostrando:
--   Id, Nome, Cognome, DataNascita

--2) Elenca le anagrafiche ordinate per Cognome e Nome (A → Z)

--3) Trova le anagrafiche che NON hanno Email
--   (Email IS NULL oppure stringa vuota)

--4) Mostra tutti i docenti con:
--   Id, AnagraficaId, Categoria, DataInserimento

--5) Mostra tutti gli studenti con:
--   Id, Matricola, StatoOccupazionale, DataInserimento

--6) Elenca i corsi finanziati (Finanziato = 1)
--   mostrando Titolo ed EnteFinanziatore

--7) Elenca i corsi con TotaleOre >= 100
--   mostrando Titolo e TotaleOre

--8) Trova tutte le lezioni con Test = 1
--   mostrando Data, OrarioInizio, OrarioFine, Ufc, Sede


--========================
--LIVELLO 2 – JOIN
--========================

--9) Elenca tutti gli studenti con nome e cognome:
--   Studenti.Id, Matricola, Nome, Cognome

--10) Elenca tutti i docenti con nome e cognome:
--    Docenti.Id, Nome, Cognome, Categoria

--11) Per ogni iscrizione mostra:
--    IdIscrizione, TitoloCorso, MatricolaStudente, DataIscrizione

--12) Elenca le lezioni con:
--    Data, OrarioInizio, OrarioFine,
--    TitoloCorso, NomeDocente, CognomeDocente

--13) Per ogni corso mostra i docenti associati:
--    TitoloCorso, NomeDocente, CognomeDocente, IsDocentePrincipale

--14) Elenca le presenze con:
--    TitoloCorso, DataLezione, Matricola,
--    Nome, Cognome, OrePresenza

--15) Trova tutte le iscrizioni ritirate
--    mostrando anche DataRitiro

--16) Elenca tutte le lezioni svolte in una sede specifica
--    (es. Sede = 'Perugia') con corso e docente


--========================
--LIVELLO 3 – AGGREGAZIONI
--========================

--17) Conta quanti studenti ci sono in totale

--18) Conta il numero di iscritti per ogni corso:
--    TitoloCorso, NumeroIscritti
--    (ordinare dal più alto al più basso)

--19) Per ogni docente conta quanti corsi tiene:
--    Docente, NumeroCorsi

--20) Per ogni corso conta quante lezioni sono previste:
--    TitoloCorso, NumeroLezioni

--21) Per ogni corso calcola il totale delle ore di presenza:
--    TitoloCorso, OreTotaliPresenza

--22) Per ogni studente calcola le ore totali di presenza:
--    Matricola, Nome, Cognome, OreTotali


--========================
--LIVELLO 4 – SUBQUERY / EXISTS
--========================

--23) Trova i docenti che insegnano almeno un corso
--    (usare EXISTS)

--24) Trova i docenti che NON insegnano alcun corso
--    (NOT EXISTS o anti-join)

--25) Trova gli studenti iscritti ad almeno un corso
--    ma che NON hanno nessuna presenza

--26) Trova i corsi che hanno iscritti
--    ma nessuna lezione programmata


--========================
--LIVELLO 5 – CTE / WINDOW / REAL LIFE
--========================

--27) Per ogni corso mostra la classifica dei docenti
--    in base a TotaleOreEffettuate:
--    TitoloCorso, Docente, TotaleOreEffettuate, Rank
--    (usare RANK o DENSE_RANK)

--28) Per ogni studente e corso calcola:
--    - ore totali di presenza
--    - percentuale di presenza su TotaleOre del corso
--    Output:
--    Matricola, TitoloCorso, OrePresenzaTot, Percentuale

--29) Trova le presenze incoerenti:
--    OrePresenza NON compatibile con
--    EntraAlle / EsceAlle
--    (DATEDIFF in minuti vs OrePresenza * 60)

--30) REPORT COMPLETO (CTE):
--    Per ogni corso mostra:
--    - numero iscritti attivi
--    - numero iscritti ritirati
--    - totale ore lezione
--    - totale ore presenza
--    (una riga per corso)

--========================================
--Regola:
--Scrivi le query in ordine.
--Quando vuoi, incollale e verranno
--corrette e spiegate una per una.
--========================================





-- SOLUZIONI

--1) Seleziona tutte le anagrafiche mostrando:
--   Id, Nome, Cognome, DataNascita
-- SELECT Id, Nome, Cognome, DataNascita FROM Anagrafiche;

--2) Elenca le anagrafiche ordinate per Cognome e Nome (A → Z)
-- SELECT * FROM Anagrafiche ORDER BY Cognome, Nome;

--3) Trova le anagrafiche che NON hanno Email
--   (Email IS NULL oppure stringa vuota)
-- SELECT * FROM Anagrafiche WHERE Email IS NULL OR LTRIM(RTRIM(Email)) = '';

--4) Mostra tutti i docenti con:
--   Id, AnagraficaId, Categoria, DataInserimento
-- SELECT Id, AnagraficaId, Categoria, DataInserimento FROM Docenti;

--5) Mostra tutti gli studenti con:
--   Id, Matricola, StatoOccupazionale, DataInserimento
-- SELECT Id, Matricola, StatoOccupazionale, DataInserimento FROM Studenti;

--6) Elenca i corsi finanziati (Finanziato = 1)
--   mostrando Titolo ed EnteFinanziatore
-- SELECT Titolo, EnteFinanziatore FROM Corsi WHERE Finanziato = 1;

--7) Elenca i corsi con TotaleOre >= 100
--   mostrando Titolo e TotaleOre
-- SELECT Titolo, TotaleOre FROM Corsi WHERE TotaleOre >= 100;

--8) Trova tutte le lezioni con Test = 1
--   mostrando Data, OrarioInizio, OrarioFine, Ufc, Sede
-- SELECT [Data], OrarioInizio, OrarioFine, Ufc, Sede FROM Lezioni WHERE Test = 1;

--9) Elenca tutti gli studenti con nome e cognome:
--   Studenti.Id, Matricola, Nome, Cognome
-- SELECT s.Id AS "ID Studente", Matricola, Nome, Cognome FROM Studenti s
-- JOIN Anagrafiche a ON s.AnagraficaId = a.Id

--10) Elenca tutti i docenti con nome e cognome:
--    Docenti.Id, Nome, Cognome, Categoria
-- SELECT d.id AS "ID Docente", Nome, Cognome, Categoria FROM Docenti d
-- JOIN Anagrafiche a ON d.AnagraficaId = a.id;

--11) Per ogni iscrizione mostra:
--    IdIscrizione, TitoloCorso, MatricolaStudente, DataIscrizione
-- SELECT i.id AS "ID Iscrizione", Titolo, Matricola, DataIscrizione FROM Iscrizioni i
-- JOIN Studenti s ON i.StudenteId = s.id
-- JOIN Corsi c ON i.CorsoId = c.id;

--12) Elenca le lezioni con:
--    Data, OrarioInizio, OrarioFine,
--    TitoloCorso, NomeDocente, CognomeDocente
--SELECT [Data], OrarioInizio, OrarioFine, Titolo AS 'Titolo Corso', Cognome + ' ' + Nome AS 'Docente' 
--FROM Lezioni l
--JOIN DocentiCorsi dc ON dc.Id = l.DocentiCorsiId
--JOIN Corsi c ON c.id = dc.CorsoId
--JOIN Docenti d ON d.id = dc.DocenteId
--JOIN Anagrafiche a ON d.AnagraficaId = a.id;

--13) Per ogni corso mostra i docenti associati:
--    TitoloCorso, NomeDocente, CognomeDocente, IsDocentePrincipale
--SELECT Titolo AS "Titolo Corso", Cognome + ' ' + Nome AS "Docente", IsDocentePrincipale
--FROM DocentiCorsi dc
--JOIN Corsi c ON c.Id = dc.CorsoId
--JOIN Docenti d ON d.Id = dc.DocenteId
--JOIN Anagrafiche a ON a.Id = d.AnagraficaId;

--14) Elenca le presenze con:
--    TitoloCorso, DataLezione, Matricola,
--    Nome, Cognome, OrePresenza
--SELECT Titolo AS 'Titolo Corso', l.[Data] AS 'Data Lezione', Matricola, Cognome + ' ' + Nome AS "Studente", OrePresenza
--FROM Presenze p
--JOIN Lezioni l ON l.id = p.LezioneId
--JOIN Iscrizioni i ON i.id = p.IscrizioneId
--JOIN Corsi c ON c.id = i.CorsoId
--JOIN Studenti s ON s.id = i.StudenteId
--JOIN Anagrafiche a ON a.id = s.AnagraficaId;

--15) Trova tutte le iscrizioni ritirate
--    mostrando anche DataRitiro
--SELECT i.id AS 'ID Iscrizione', Matricola, Cognome + ' ' + Nome AS Studente, Titolo AS 'Titolo Corso', DataIscrizione, DataRitiro
--FROM Iscrizioni i
--JOIN Corsi c ON c.Id = i.CorsoId
--JOIN Studenti s ON s.Id = i.StudenteId
--JOIN Anagrafiche a ON a.Id = s.AnagraficaId
--WHERE Ritirato = 1 AND DataRitiro IS NOT NULL;

--16) Elenca tutte le lezioni svolte in una sede specifica
--    (es. Sede = 'Perugia') con corso e docente
--SELECT l.id AS 'ID Lezione', Sede, [Data], OrarioInizio, OrarioFine, Titolo AS 'Titolo Corso', Cognome + ' ' + Nome AS Docente
--FROM Lezioni l
--JOIN DocentiCorsi dc ON dc.id = l.DocentiCorsiId
--JOIN Docenti d ON d.id = dc.DocenteId
--JOIN Corsi c ON c.id = dc.CorsoId
--JOIN Anagrafiche a ON a.id = d.AnagraficaId
--WHERE LTRIM(RTRIM(LOWER(Sede))) = 'aula 1'

--17) Conta quanti studenti ci sono in totale
--SELECT COUNT(*) FROM Studenti;

--18) Conta il numero di iscritti per ogni corso:
--    TitoloCorso, NumeroIscritti
--    (ordinare dal più alto al più basso)
--SELECT Titolo, COUNT(*) AS NumeroIscritti
--FROM Iscrizioni i
--JOIN Corsi c ON c.Id = i.CorsoId
--GROUP BY Titolo
--ORDER BY NumeroIscritti DESC;

--19) Per ogni docente conta quanti corsi tiene:
--    Docente, NumeroCorsi
--SELECT Nome + ' ' + Cognome AS Docente, COUNT(*) AS NumeroCorsi
--FROM DocentiCorsi dc
--JOIN Docenti d ON d.id = dc.DocenteId
--JOIN Anagrafiche a ON a.id = d.AnagraficaId
--GROUP BY Nome, Cognome;

--20) Per ogni corso conta quante lezioni sono previste:
--    TitoloCorso, NumeroLezioni
--SELECT Titolo AS TitoloCorso, COUNT(*) AS NumeroLezioni
--FROM Lezioni l 
--JOIN DocentiCorsi dc ON dc.id = l.DocentiCorsiId
--JOIN Corsi c ON c.id = dc.CorsoId
--GROUP BY Titolo;

--21) Per ogni corso calcola il totale delle ore di presenza:
--    TitoloCorso, OreTotaliPresenza
--SELECT c.Titolo AS TitoloCorso, SUM(p.OrePresenza) AS OreTotaliPresenza
--FROM Presenze p
--JOIN Iscrizioni i ON i.Id = p.IscrizioneId
--JOIN Corsi c ON c.Id = i.CorsoId
--GROUP BY c.Titolo;

--22) Per ogni studente calcola le ore totali di presenza:
--    Matricola, Nome, Cognome, OreTotali
--SELECT s.Matricola, a.Nome, a.Cognome, SUM(p.OrePresenza) AS OreTotali
--FROM Presenze p 
--JOIN Iscrizioni i ON i.Id = p.IscrizioneId
--JOIN Studenti s ON s.Id = i.StudenteId
--JOIN Anagrafiche a ON a.Id = s.AnagraficaId
--GROUP BY s.Matricola, a.Nome, a.Cognome;

--23) Trova i docenti che insegnano almeno un corso
--    (usare EXISTS)
--SELECT a.Cognome + ' ' + a.Nome AS Docente
--FROM Docenti d
--JOIN Anagrafiche a ON a.Id = d.AnagraficaId
--WHERE EXISTS( 
--	SELECT 1 
--	FROM DocentiCorsi dc
--	WHERE dc.DocenteId = d.Id
--)

--24) Trova i docenti che NON insegnano alcun corso
--    (NOT EXISTS o anti-join)
--SELECT a.Cognome + ' ' + a.Nome AS Docente
--FROM Docenti d
--JOIN Anagrafiche a ON a.Id = d.AnagraficaId
--WHERE NOT EXISTS( 
--	SELECT 1 
--	FROM DocentiCorsi dc
--	WHERE dc.DocenteId = d.Id
--)


--25) Trova gli studenti iscritti ad almeno un corso
--    ma che NON hanno nessuna presenza
--SELECT DISTINCT a.Cognome + ' ' + a.Nome AS Studente
--FROM Studenti s
--JOIN Anagrafiche a ON a.Id = s.AnagraficaId
--JOIN Iscrizioni i ON i.StudenteId = s.Id
--WHERE NOT EXISTS(
--	SELECT 1 
--	FROM Presenze p
--	JOIN Iscrizioni i1 ON i1.Id = p.IscrizioneId
--	WHERE s.Id = i1.StudenteId
--)

--26) Trova i corsi che hanno iscritti
--    ma nessuna lezione programmata
--SELECT c.Titolo AS TitoloCorso
--FROM Corsi c
--WHERE EXISTS( -- Questo permette di evitare di ripetere le righe come farebbe join
--	SELECT 1
--	FROM Iscrizioni i 
--	WHERE i.CorsoId = c.id
--) AND 
--NOT EXISTS(
--	SELECT 1
--	FROM Lezioni l
--	JOIN DocentiCorsi dc ON l.DocentiCorsiId = dc.id
--	WHERE dc.CorsoId = c.Id
--)