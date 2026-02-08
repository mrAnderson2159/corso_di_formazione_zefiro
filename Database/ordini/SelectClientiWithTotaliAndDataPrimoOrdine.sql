SELECT c.*, OrdiniTotali, ImportoTotaleOrdinato, DataPrimoOrdine
FROM Clienti c
LEFT JOIN (
	SELECT o.ClienteId AS ClienteId, 
		   COUNT(o.ClienteId) AS OrdiniTotali, 
		   SUM(do.Prezzo * do.Quantita) AS ImportoTotaleOrdinato,
		   MIN(o.DataOrdine) AS DataPrimoOrdine
	FROM Ordini o 
	JOIN DettagliOrdini do ON o.ID = do.OrdineID
	GROUP BY o.ClienteID
) AS X ON c.Id = X.ClienteId
WHERE c.Deleted = 0
ORDER BY c.Cognome, c.Nome;