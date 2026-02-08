/* =========================
   POPOLAMENTO DATABASE
   20 clienti, 10 prodotti, 50 ordini, 225 dettagli
   ========================= */

/* ---------- CLIENTI (20) ---------- */
INSERT INTO Clienti
(Nome, Cognome, CodiceFiscale, PartitaIVA, Email, Telefono, Indirizzo, DataRegistrazione)
VALUES
('Marco','Rossi','RSSMRC90A01H501Z',NULL,'marco.rossi@mail.test','3331000001','Via Roma 10, Perugia','2025-10-12T09:15:00'),
('Luca','Bianchi','BNCLCU88B12G478Y','01234567890','luca.bianchi@mail.test','3331000002','Via Firenze 22, Perugia','2025-10-16T11:05:00'),
('Giulia','Verdi','VRDGLI92C23F205X',NULL,'giulia.verdi@mail.test','3331000003','Via Milano 5, Terni','2025-10-20T18:40:00'),
('Sara','Neri','NRISRA95D04H501W',NULL,'sara.neri@mail.test','3331000004','Via del Corso 3, Arezzo','2025-10-23T08:30:00'),
('Paolo','Gallo','GLLPLA86E15D612V','09876543210','paolo.gallo@mail.test','3331000005','Via Trasimeno 7, Perugia','2025-10-28T13:10:00'),
('Elena','Conti','CNTLNE93F26C351U',NULL,'elena.conti@mail.test','3331000006','Via del Sole 1, Siena','2025-11-02T17:55:00'),
('Andrea','Romano','RMNNDR89G07H501T',NULL,'andrea.romano@mail.test','3331000007','Viale Europa 44, Perugia','2025-11-06T10:20:00'),
('Francesca','Esposito','SPSFNC91H18F839S',NULL,'francesca.esposito@mail.test','3331000008','Via Napoli 12, Roma','2025-11-10T12:45:00'),
('Matteo','Ferrari','FRRMTT87I29L219R','12312312312','matteo.ferrari@mail.test','3331000009','Via dei Pini 9, Perugia','2025-11-14T09:00:00'),
('Chiara','Russo','RSSCHR94L10H501Q',NULL,'chiara.russo@mail.test','3331000010','Via Garibaldi 8, Foligno','2025-11-17T19:30:00'),
('Davide','Costa','CSTDVD90M21G273P',NULL,'davide.costa@mail.test','3331000011','Via Umbria 6, Spoleto','2025-11-21T14:15:00'),
('Alessia','Greco','GRCLSS96N02H501O',NULL,'alessia.greco@mail.test','3331000012','Via delle Rose 2, Perugia','2025-11-26T16:05:00'),
('Simone','Marini','MRNSMN85A13F205N','22233344455','simone.marini@mail.test','3331000013','Piazza Italia 1, Perugia','2025-12-01T10:10:00'),
('Valentina','Barbieri','BRBVNT93B24H501M',NULL,'valentina.barbieri@mail.test','3331000014','Via dei Tigli 15, Todi','2025-12-05T09:50:00'),
('Stefano','Rinaldi','RNLSTF88C05D612L',NULL,'stefano.rinaldi@mail.test','3331000015','Via della Vittoria 19, Perugia','2025-12-09T11:35:00'),
('Martina','Caruso','CRSMTN92D16F839K',NULL,'martina.caruso@mail.test','3331000016','Via del Lago 4, Castiglione del Lago','2025-12-14T18:25:00'),
('Giorgio','Colombo','CLMGRG86E27H501J','77788899900','giorgio.colombo@mail.test','3331000017','Via del Teatro 6, Perugia','2025-12-20T08:05:00'),
('Ilaria','De Luca','DLCLRI95F08G478I',NULL,'ilaria.deluca@mail.test','3331000018','Via Monteluce 3, Perugia','2025-12-27T20:10:00'),
('Federico','Moretti','MRTFRC89G19C351H',NULL,'federico.moretti@mail.test','3331000019','Via San Francesco 11, Assisi','2026-01-04T09:40:00'),
('Beatrice','Fontana','FNTBRC97H30H501G',NULL,'beatrice.fontana@mail.test','3331000020','Via Perugina 21, Bastia Umbra','2026-01-10T15:55:00');

/* ---------- PRODOTTI (10) ---------- */
INSERT INTO Prodotti (Nome, Prezzo, InStock)
VALUES
('Caffè Arabica 1kg', 19.90, 1),
('Caffè Robusta 1kg', 16.90, 1),
('Caffè Decaffeinato 250g', 6.50, 1),
('Cialde Espresso Classico (50pz)', 14.90, 1),
('Cialde Espresso Intenso (50pz)', 15.90, 1),
('Cialde Deca (50pz)', 15.50, 1),
('Capsule Compatibili Classic (100pz)', 24.90, 1),
('Capsule Compatibili Intense (100pz)', 26.90, 1),
('Moka Blend 250g', 5.90, 1),
('Filtro Americano 250g', 5.50, 0);

/* ---------- ORDINI (50) ----------
   Numero: ORD-2026-0001 ... ORD-2026-0050
*/
INSERT INTO Ordini (ClienteID, DataOrdine, Numero)
VALUES
( 1,'2026-01-05T10:10:00','ORD-2026-0001'),
( 2,'2026-01-05T11:20:00','ORD-2026-0002'),
( 3,'2026-01-06T09:00:00','ORD-2026-0003'),
( 4,'2026-01-06T16:45:00','ORD-2026-0004'),
( 5,'2026-01-07T13:15:00','ORD-2026-0005'),
( 6,'2026-01-07T18:05:00','ORD-2026-0006'),
( 7,'2026-01-08T08:35:00','ORD-2026-0007'),
( 8,'2026-01-08T12:50:00','ORD-2026-0008'),
( 9,'2026-01-09T09:25:00','ORD-2026-0009'),
(10,'2026-01-09T17:40:00','ORD-2026-0010'),
(11,'2026-01-10T10:05:00','ORD-2026-0011'),
(12,'2026-01-10T14:30:00','ORD-2026-0012'),
(13,'2026-01-11T09:15:00','ORD-2026-0013'),
(14,'2026-01-11T19:20:00','ORD-2026-0014'),
(15,'2026-01-12T11:00:00','ORD-2026-0015'),
(16,'2026-01-12T16:10:00','ORD-2026-0016'),
(17,'2026-01-13T08:55:00','ORD-2026-0017'),
(18,'2026-01-13T12:05:00','ORD-2026-0018'),
(19,'2026-01-14T10:35:00','ORD-2026-0019'),
(20,'2026-01-14T18:00:00','ORD-2026-0020'),
( 1,'2026-01-15T09:40:00','ORD-2026-0021'),
( 2,'2026-01-15T15:25:00','ORD-2026-0022'),
( 3,'2026-01-16T10:10:00','ORD-2026-0023'),
( 4,'2026-01-16T17:05:00','ORD-2026-0024'),
( 5,'2026-01-17T11:50:00','ORD-2026-0025'),
( 6,'2026-01-17T19:15:00','ORD-2026-0026'),
( 7,'2026-01-18T09:05:00','ORD-2026-0027'),
( 8,'2026-01-18T12:40:00','ORD-2026-0028'),
( 9,'2026-01-19T10:20:00','ORD-2026-0029'),
(10,'2026-01-19T16:55:00','ORD-2026-0030'),
(11,'2026-01-20T09:35:00','ORD-2026-0031'),
(12,'2026-01-20T14:10:00','ORD-2026-0032'),
(13,'2026-01-21T10:00:00','ORD-2026-0033'),
(14,'2026-01-21T18:20:00','ORD-2026-0034'),
(15,'2026-01-22T11:15:00','ORD-2026-0035'),
(16,'2026-01-22T16:50:00','ORD-2026-0036'),
(17,'2026-01-23T08:45:00','ORD-2026-0037'),
(18,'2026-01-23T12:15:00','ORD-2026-0038'),
(19,'2026-01-24T10:25:00','ORD-2026-0039'),
(20,'2026-01-24T17:35:00','ORD-2026-0040'),
( 1,'2026-01-25T09:10:00','ORD-2026-0041'),
( 2,'2026-01-25T13:55:00','ORD-2026-0042'),
( 3,'2026-01-26T10:05:00','ORD-2026-0043'),
( 4,'2026-01-26T16:30:00','ORD-2026-0044'),
( 5,'2026-01-27T11:45:00','ORD-2026-0045'),
( 6,'2026-01-27T19:05:00','ORD-2026-0046'),
( 7,'2026-01-28T09:20:00','ORD-2026-0047'),
( 8,'2026-01-28T12:35:00','ORD-2026-0048'),
( 9,'2026-01-29T10:50:00','ORD-2026-0049'),
(10,'2026-01-29T18:15:00','ORD-2026-0050');