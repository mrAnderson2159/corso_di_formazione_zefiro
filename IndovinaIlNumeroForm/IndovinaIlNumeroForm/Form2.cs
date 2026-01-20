using IndovinaIlNumeroForm.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IndovinaIlNumeroForm
{
    public partial class Form2 : Form
    {
        private readonly Logica _logic;

        public Form2(Logica logic)
        {
            InitializeComponent();
            _logic = logic;
            txtMinimo.Value = _logic.Minimo;
            txtMassimo.Value = _logic.Massimo;
        }

        private void SetValues()
        {
            _logic.Minimo = (int)txtMinimo.Value;
            _logic.Massimo = (int)txtMassimo.Value;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SetValues();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _logic.Minimo = _initMin;
            _logic.Massimo = _initMax;
            this.Close();
        }

        private void txtMinimo_ValueChanged(object sender, EventArgs e)
        {
            SetValues();
        }

        private void txtMassimo_ValueChanged(object sender, EventArgs e)
        {
            SetValues();
        }
    }
}
