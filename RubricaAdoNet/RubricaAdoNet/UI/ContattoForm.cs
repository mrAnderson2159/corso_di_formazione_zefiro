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

            List<TextBox> toBeValidated = [
                txtNome,
                txtCognome
             ];
           
            foreach (TextBox txt in toBeValidated)
            {
                txt.Validating += ValidatingTextBoxVuota;
                txt.Validated += ValidetedTextBox;
            }
               
        }

        private void ValidatingTextBoxVuota(object? sender, CancelEventArgs e)
        {
            if (sender is TextBox txt && txt.Text == string.Empty)
            {
                txt.BackColor = Color.LightCoral;
                // Non permetto che si scateni validated
                e.Cancel = true;
            }
        }

        private void ValidetedTextBox(object? sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.BackColor = Color.White;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
