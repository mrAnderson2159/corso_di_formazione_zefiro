using SportAdoNet.DAO;
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
    public partial class SportForm : Form
    {
        private readonly List<Sport> _listSport = [];
        public SportForm()
        {
            InitializeComponent();
            bindingSourceSport.DataSource = _listSport;
            CaricaLista();
        }

        private void CaricaLista()
        {
            _listSport.Clear();
            _listSport.AddRange(SportRepository.GetAll());
            bindingSourceSport.ResetBindings(false);
        }

        private void Nuovo(object sender, EventArgs e)
        {
            Sport nuovoSport = new();
            SportDettaglioForm form = new(nuovoSport);

            if (form.ShowDialog() == DialogResult.OK)
            {
                SportRepository.Insert(nuovoSport);
                CaricaLista();
            }
        }

        private void Modifica(object sender, EventArgs e)
        {
            if (bindingSourceSport.Current is Sport modifica)
            {
                Sport clone = new();
                clone.CopyFrom(modifica);

                SportDettaglioForm form = new(clone);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    SportRepository.Update(clone);
                    CaricaLista();
                }
            }
        }

        private void Elimina(object sender, EventArgs e)
        {
            if (bindingSourceSport.Current is Sport elimina)
            {
                DialogResult result = MessageBox.Show(
                    $"Sei sicuro di voler eliminare lo sport '{elimina.Nome}'?",
                    "Conferma eliminazione",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    SportRepository.Delete(elimina);
                    CaricaLista();
                }
            }
        }
    }
}
