using SportAdoNet.DTOs;
using SportAdoNet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SportAdoNet.UI
{
    public partial class SportDettaglioForm : Form
    {
        private readonly Sport _source;
        private readonly List<ComboBoxOption> _options;
        public SportDettaglioForm(Sport source)
        {
            InitializeComponent();
            _source = source;
            bindingSourceSport.DataSource = _source;
            _options =
            [
                new("N/D", null),
                new("Si", true),
                new("No", false)
            ];
            bindingSourceComboBox.DataSource = _options;
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
