using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CollectionsForm
{
    public partial class TemperatureForm : Form
    {
        private readonly List<decimal> _listaTemperature = [];
        public TemperatureForm()
        {
            InitializeComponent();
            Inizializza();
        }

        private void Inizializza()
        {
            _listaTemperature.Clear();
            lblMin.Text = string.Empty;
            lblMax.Text = string.Empty;
            lblAvg.Text = string.Empty;
            lstTemperature.Items.Clear();

            txtTemperature.Select();
            txtTemperature.Focus();
        }

        private void Insert(decimal temperatura)
        {
            _listaTemperature.Add(temperatura);
            lstTemperature.Items.Insert(0, temperatura);
            txtTemperature.Select();
            txtTemperature.Focus();
        }

        private decimal? Calcolatore(Func<decimal, decimal, bool> compare)
        {
            if (_listaTemperature.Count == 0) return null;

            decimal result = _listaTemperature[0];

            for (int i = 1; i < _listaTemperature.Count; i++)
            {
                decimal t = _listaTemperature[i];

                if (compare(t, result))
                {
                    result = t;
                }
            }

            return result;
        }

        private decimal? CalcolaMinima()
        {
            // Ad ogni iterazione verifica se l'elemento
            // è minore della variabile di ritorno
            return Calcolatore((el, ret) => el < ret);
        }

        private decimal? CalcolaMassima()
        {
            // Ad ogni iterazione verifica se l'elemento
            // è maggiore della variabile di ritorno
            return Calcolatore((el, ret) => el > ret);
        }

        private decimal? CalcolaMedia()
        {
            if (_listaTemperature.Count == 0) return null;

            decimal sum = 0;

            foreach (decimal t in _listaTemperature)
            {
                sum += t;
            }

            return sum / _listaTemperature.Count;
        }

        public static decimal? GetOrAlert(Func<decimal?> mathFunc)
        {
            decimal? res = mathFunc();

            if (res == null)
            {
                MessageBox.Show("Devi prima inserire delle temperature",
                    "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return null;
            }

            return res;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Inizializza();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert(txtTemperature.Value);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            decimal? min = GetOrAlert(CalcolaMinima);

            if (min == null) return;

            lblMin.Text = min.ToString();
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            decimal? avg = GetOrAlert(CalcolaMedia);

            if (avg == null) return;

            lblAvg.Text = Math.Round((decimal)avg, 2).ToString();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            decimal? max = GetOrAlert(CalcolaMassima);

            if (max == null) return;

            lblMax.Text = max.ToString();
        }

        private void txtTemperature_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Insert(txtTemperature.Value);
            }
        }
    }
}
