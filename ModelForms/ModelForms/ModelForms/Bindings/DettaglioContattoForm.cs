using ModelForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelForms.Bindings
{
    public partial class DettaglioContattoForm : Form
    {
        private readonly Contatto _source;
        public DettaglioContattoForm(Contatto source)
        {
            InitializeComponent();
            _source = source;
            bindingSource1.DataSource = _source;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
