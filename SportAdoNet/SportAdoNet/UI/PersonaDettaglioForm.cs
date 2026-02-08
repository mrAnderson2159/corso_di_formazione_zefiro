using SportAdoNet.DAO;
using SportAdoNet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportAdoNet.UI
{
    public partial class PersonaDettaglioForm : Form
    {
        private readonly Persona _source;
        private readonly List<Sport> _listSport;

        public PersonaDettaglioForm(Persona source)
        {
            InitializeComponent();
            _listSport = [new() { Nome = "--- Nessuno Sport ---", Id = 0 }];
            _listSport.AddRange(SportRepository.GetAll());
            // Uso 0 come id no-sport
            _source = source;
            SerializeSportId(false);
            bindingSourcePersona.DataSource = _source;
            bindingSourceSport.DataSource = _listSport;
        }

        private void SerializeSportId(bool setNull)
        {
            if (_source.IdSport == 0 && setNull)
            {
                _source.IdSport = null;
                return;
            }

            if (!setNull)
            {
                _source.IdSport ??= 0;
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            SerializeSportId(true);
            Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            SerializeSportId(true);
            Close();
        }
    }
}
