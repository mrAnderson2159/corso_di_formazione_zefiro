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
    public partial class ClientiDettaglioForm : Form
    {
        private readonly ClienteDTO _source;
        public ClientiDettaglioForm(ClienteDTO source)
        {
            InitializeComponent();
            _source = source;
            bindingSourceClientDTO.DataSource = _source;
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
