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
    public partial class OrdiniDettaglioForm : Form
    {
        private readonly OrdineDTO _source;
        private readonly List<ClienteDTO> _listClienti = [];

        public OrdiniDettaglioForm(OrdineDTO source)
        {
            InitializeComponent();
            _source = source;
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OrdiniDettaglioForm_Load(object sender, EventArgs e)
        {
            _listClienti.Clear();
            _listClienti.AddRange(ClientiManager.GetAll());
            bindingSourceClientiDTO.DataSource = _listClienti;
            bindingSourceOrdiniDTO.DataSource = _source;
        }
    }
}
