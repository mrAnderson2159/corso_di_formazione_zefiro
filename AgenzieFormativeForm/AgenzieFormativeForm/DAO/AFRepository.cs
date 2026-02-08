using System;
using System.Collections.Generic;
using System.Text;

namespace AgenzieFormativeForm.DAO
{
    internal class AFRepository
    {
        private const string ANAGRAFICHE_ATTRS =
            "Nome, Cognome, CodiceFiscale, DataNascita, IndirizzoResidenza, CittaResidenza, NumeroTelefono, Email, Pec, Sesso";
        private const string DOCENTE_ATTRS =
            "AnagraficaId, StatoCollaborazione, DataAssunzione, DataInserimento, Categoria";
        private const string STUDENTE_ATTRS =
            "AnagraficaId, Matricola, DataInserimento, StatoOccupazionale";
        private const string CORSO_ATTRS =
            "Titolo, TotaleOre, Finanziato, EnteFinanziatore, DataInizio, DataFine, DataEsame, ModalitaErogazione";
        private const string DOCENTI_CORSI_ATTRS =
            "DocenteId, CorsoId, TotaleOrePreviste, TotaleOreEffettuate, IsDocentePrincipale";
        private const string LEZIONE_ATTRS =
            "DocentiCorsiId, Data, Argomento, Ufc, OrarioInizio, OrarioFine, Sede, Test";
        private const string ISCRIZIONE_ATTRS =
            "StudenteId, CorsoId, DataIscrizione, Ritirato, DataRitiro, CostoIscrizione";
        private const string PRESENZA_ATTRS =
            "IscrizioneId, LezioneId, OrePresenza, EntraAlle, EsceAlle";

        private const string ANAGRAFICHE = "Anagrafiche";
        private const string DOCENTI = "Docenti";
        private const string STUDENTI = "Studenti";
        private const string CORSI = "Corsi";
        private const string DOCENTI_CORSI = "DocentiCorsi";
        private const string LEZIONI = "Lezioni";
        private const string ISCRIZIONI = "Iscrizioni";
        private const string PRESENZE = "Presenze";
    }
}
