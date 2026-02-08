using LibriAdoNet.DAO;
using LibriAdoNet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibriAdoNet.UI
{
    public partial class LibroForm : Form
    {
        private readonly Libro _source;

        public LibroForm(Libro libro)
        {
            InitializeComponent();
            _source = libro;
            bindingSource1.DataSource = _source;

            List<TextBox> toValidate = [
                txtTitolo,
                txtAutore,
            ];

            foreach (TextBox txt in toValidate)
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

        private void Salva(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        
        private void Annulla(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
