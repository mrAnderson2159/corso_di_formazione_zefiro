using OrdiniAdoNet.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrdiniAdoNet.UI.Prodotti
{
    public partial class ProdottiDettaglioForm : Form
    {
        private readonly ProdottoDTO _source;
        public ProdottiDettaglioForm(ProdottoDTO source)
        {
            InitializeComponent();
            _source = source;
            bindingSourceProductDTO.DataSource = _source;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
