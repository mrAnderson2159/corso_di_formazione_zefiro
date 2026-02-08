using OrdiniAdoNet.Business;
using OrdiniAdoNet.DAO;
using OrdiniAdoNet.DTOs;
using OrdiniAdoNet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrdiniAdoNet.UI.Clienti
{
    public partial class ClientiForm : Form
    {
        private readonly List<ClienteDTO> _listClienti = [];
        public ClientiForm()
        {
            InitializeComponent();
            bindingSourceClientsDTO.DataSource = _listClienti;
            AggiornaListaClienti();
            AggiornaInterfaccia();
        }

        private void AggiornaListaClienti(List<ClienteDTO>? nuovaLista = null)
        {
            _listClienti.Clear();
            _listClienti.AddRange(nuovaLista ?? ClientiManager.GetAll());
        }

        private void AggiornaInterfaccia()
        {
            bindingSourceClientsDTO.ResetBindings(false);
        }

        private void Nuovo(object sender, EventArgs e)
        {
            ClienteDTO nuovo = new();
            ClientiDettaglioForm form = new(nuovo);
            
            if (form.ShowDialog() == DialogResult.OK)
            {
                ClientiManager.Insert(nuovo);
                AggiornaListaClienti();
                AggiornaInterfaccia();
            }
        }

        private void Modifica(object sender, EventArgs e)
        {
            if (bindingSourceClientsDTO.Current is ClienteDTO modifica)
            {
                ClienteDTO clone = new();
                clone.CopyFrom(modifica);

                ClientiDettaglioForm form = new(clone);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    ClientiManager.Update(clone);
                    AggiornaListaClienti();
                    AggiornaInterfaccia();
                }
            }
        }

        private void Elimina(object sender, EventArgs e)
        {
            // TODO: Aggiungere il controllo per verificare se eliminabile
            if (bindingSourceClientsDTO.Current is ClienteDTO elimina)
            {
                string msg = $"Confermi l'eliminazione del cliente {elimina.InfoCliente}?";
                if (MessageBox.Show(
                        msg, 
                        "Conferma eliminazione", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Warning
                    ) == DialogResult.Yes
                )
                {
                    if (ClientiManager.CanDelete(elimina))
                    {
                        ClientiManager.Delete(elimina);
                        AggiornaListaClienti();
                        AggiornaInterfaccia();
                    } else
                    {
                        MessageBox.Show(
                            $"Non è possibile eliminare il contatto {elimina} perché ha degli ordini in sospeso"
                            , "Eliminazione non consentita"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Warning
                        );
                    }
                }
            }
        }

        private void CercaPerNome(object sender, EventArgs e)
        {
            string filter = txtNameSearch.Text;

            if (filter.Length == 0)
            {
                AggiornaListaClienti();
            }
            else
            {
                AggiornaListaClienti(ClientiManager.CercaPerNome(filter));
            }
            AggiornaInterfaccia();
        }
    }
}
