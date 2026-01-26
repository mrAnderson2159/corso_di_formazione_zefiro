using RubricaAdoNet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RubricaAdoNet.UI
{
    public partial class ContattoForm : Form
    {
        private readonly Contatto _source;

        public ContattoForm(Contatto source)
        {
            InitializeComponent();
            _source = source;
            bindingSource1.DataSource = _source;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
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
