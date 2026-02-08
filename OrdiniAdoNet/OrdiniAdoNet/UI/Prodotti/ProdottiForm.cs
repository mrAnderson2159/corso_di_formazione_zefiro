using OrdiniAdoNet.DAO;
using OrdiniAdoNet.DTOs;
using OrdiniAdoNet.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrdiniAdoNet.UI.Prodotti
{
    public partial class ProdottiForm : Form
    {
        private readonly List<ProdottoDTO> _listProdotti = [];
        public ProdottiForm()
        {
            InitializeComponent();
            bindingSourceProductsDTO.DataSource = _listProdotti;
            AggiornaListaProdotti();
            AggiornaInterfaccia();
        }

        private void AggiornaListaProdotti(List<ProdottoDTO>? nuovaLista = null)
        {
            _listProdotti.Clear();
            _listProdotti.AddRange(nuovaLista ?? ProdottiManager.GetAll());
        }

        private void AggiornaInterfaccia()
        {
            bindingSourceProductsDTO.ResetBindings(false);
        }

        private void Nuovo(object sender, EventArgs e)
        {
            ProdottoDTO nuovo = new();
            ProdottiDettaglioForm form = new(nuovo);
            
            if (form.ShowDialog() == DialogResult.OK)
            {
                ProdottiManager.Insert(nuovo);
                AggiornaListaProdotti();
                AggiornaInterfaccia();
            }
        }

        private void Modifica(object sender, EventArgs e)
        {
            if (bindingSourceProductsDTO.Current is ProdottoDTO modifica)
            {
                ProdottoDTO clone = new();
                clone.CopyFrom(modifica);

                ProdottiDettaglioForm form = new(clone);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    ProdottiManager.Update(clone);
                    AggiornaListaProdotti();
                    AggiornaInterfaccia();
                }
            }
        }

        private void Elimina(object sender, EventArgs e) {
            if (bindingSourceProductsDTO.Current is ProdottoDTO elimina)
            {
                
                var result = MessageBox.Show("Sei sicuro di voler eliminare il prodotto selezionato?", 
                                             "Conferma eliminazione", 
                                             MessageBoxButtons.YesNo, 
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!ProdottiManager.CanDelete(elimina))
                    {
                        MessageBox.Show("Impossibile eliminare il prodotto selezionato perché è associato a uno o più ordini.",
                                        "Eliminazione non consentita",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return;
                    }
                    ProdottiManager.Delete(elimina);
                    AggiornaListaProdotti();
                    AggiornaInterfaccia();
                }
            }
        }

        private void CercaPerNome(object sender, EventArgs e)
        {
            string filter = txtNameSearch.Text;

            if (filter.Length == 0)
            {
                AggiornaListaProdotti();
            }
            else
            {
                AggiornaListaProdotti(ProdottiManager.CercaPerNome(filter));
            }
            AggiornaInterfaccia();
        }
    }
}
