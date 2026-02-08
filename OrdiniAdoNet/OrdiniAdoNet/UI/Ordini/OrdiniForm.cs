using OrdiniAdoNet.Business;
using OrdiniAdoNet.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrdiniAdoNet.UI.Ordini
{
    public partial class OrdiniForm : Form
    {
        private readonly List<OrdineDTO> _listOrdini = [];

        public OrdiniForm()
        {
            InitializeComponent();
            bindingSourceOrdini.DataSource = _listOrdini;
        }

        private void AggiornaOrdini(List<OrdineDTO>? ordini = null)
        {
            _listOrdini.Clear();
            _listOrdini.AddRange(ordini ?? OrdiniManager.GetAllOrdini());
        }

        private void AggiornaInterfaccia()
        {
            bindingSourceOrdini.ResetBindings(false);
        }

        private void OrdiniForm_Load(object sender, EventArgs e)
        {
            AggiornaOrdini();
            AggiornaInterfaccia();
        }

        private void Nuovo(object sender, EventArgs e)
        {
            OrdineDTO nuovo = new();
            OrdiniDettaglioForm form = new(nuovo);

            if (form.ShowDialog() == DialogResult.OK)
            {
                OrdiniManager.InsertOrdine(nuovo);
                AggiornaOrdini();
                AggiornaInterfaccia();
            }
        }

        private void Modifica(object sender, EventArgs e)
        {
            if (bindingSourceOrdini.Current is OrdineDTO modifica)
            {
                OrdineDTO clone = new();
                clone.CopyFrom(modifica);

                OrdiniDettaglioForm form = new(clone);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    OrdiniManager.UpdateOrdine(clone);
                    AggiornaOrdini();
                    AggiornaInterfaccia();
                }
            }
        }


    }
}
