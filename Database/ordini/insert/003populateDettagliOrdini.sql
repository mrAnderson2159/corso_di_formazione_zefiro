SET NOCOUNT ON;

-- 1) pulizia
DELETE FROM DettagliOrdini;

-- 2) generazione 225 righe
;WITH Ord AS (
    SELECT
        o.ID AS OrdineID,
        ROW_NUMBER() OVER (ORDER BY o.ID) AS rn
    FROM Ordini o
    WHERE o.ID BETWEEN 1 AND 50
),
-- 1 riga servizio per ordine (50 righe)
Servizi AS (
    SELECT
        OrdineID,
        CAST(NULL AS INT) AS ProdottoID,
        1 AS Quantita,
        CAST(
            CASE rn % 3
                WHEN 1 THEN 4.90
                WHEN 2 THEN 1.50
                ELSE 3.00
            END
        AS DECIMAL(10,2)) AS Prezzo,
        CAST(
            CASE rn % 3
                WHEN 1 THEN 'Spese di spedizione standard'
                WHEN 2 THEN 'Imballaggio rinforzato'
                ELSE 'Commissione pagamento'
            END
        AS VARCHAR(255)) AS Descrizione
    FROM Ord
),
-- righe prodotto:
-- ordini 1..25 => 4 righe prodotto
-- ordini 26..50 => 3 righe prodotto
ProdRigheBase AS (
    SELECT
        o.OrdineID,
        o.rn,
        v.slot
    FROM Ord o
    CROSS APPLY (VALUES (1),(2),(3),(4)) v(slot)
    WHERE (o.rn <= 25 AND v.slot <= 4)
       OR (o.rn >  25 AND v.slot <= 3)
),
ProdottiRighe AS (
    SELECT
        p.OrdineID,
        -- Prodotto "pseudo-random" ma deterministico: 1..10
        ((p.rn * 7 + p.slot * 3) % 10) + 1 AS ProdottoID,
        -- quantit� 1..3
        ((p.rn + p.slot) % 3) + 1 AS Quantita
    FROM ProdRigheBase p
)
INSERT INTO DettagliOrdini (OrdineID, ProdottoID, Quantita, Prezzo, Descrizione)
-- 50 righe servizi
SELECT
    s.OrdineID,
    s.ProdottoID,
    s.Quantita,
    s.Prezzo,
    s.Descrizione
FROM Servizi s

UNION ALL

-- 175 righe prodotti (con prezzo preso dalla tabella Prodotti)
SELECT
    pr.OrdineID,
    pr.ProdottoID,
    pr.Quantita,
    p.Prezzo AS Prezzo,
    NULL AS Descrizione
FROM ProdottiRighe pr
JOIN Prodotti p ON p.ID = pr.ProdottoID;

-- 3) check numeri
SELECT COUNT(*) AS TotaleDettagli FROM DettagliOrdini;   -- deve essere 225
SELECT OrdineID, COUNT(*) AS RighePerOrdine
FROM DettagliOrdini
GROUP BY OrdineID
ORDER BY OrdineID;
