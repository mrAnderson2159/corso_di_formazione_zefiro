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
    public partial class PersoneForm : Form
    {
        private readonly List<Persona> _listPersone = [];
        private readonly List<Sport> _listSport = [];
        public PersoneForm()
        {
            InitializeComponent();
            bindingSourcePersona.DataSource = _listPersone;
            bindingSourceSport.DataSource = _listSport;
            CaricaLista();
            CaricaListaSport();
        }

        private void CaricaLista(List<Persona>? listaPersone = null)
        {
            _listPersone.Clear();
            _listPersone.AddRange(listaPersone ?? PersoneRepository.GetAll());
            bindingSourcePersona.ResetBindings(false);
        }

        private void CaricaListaSport()
        {
            _listSport.Clear();
            _listSport.Add(new() { Id = -2, Nome = "--- Lista Completa --" });
            _listSport.Add(new() { Id = 0, Nome = "--- Nessuno Sport ---" });
            _listSport.Add(new() { Id = -1, Nome = "--- Fanno uno Sport ---" });
            _listSport.AddRange(SportRepository.GetAll());
            bindingSourceSport.ResetBindings(false);
        }

        private void Nuovo(object sender, EventArgs e)
        {
            Persona newPerson = new();
            PersonaDettaglioForm form = new(newPerson);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                PersoneRepository.Insert(newPerson);
                CaricaLista();
            }
        }

        private void Modifica(object sender, EventArgs e)
        {
            if (bindingSourcePersona.Current is Persona modifica)
            {
                Persona clone = new();
                clone.CopyFrom(modifica);

                PersonaDettaglioForm form = new(clone);

                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PersoneRepository.Update(clone);
                    CaricaLista();
                }
            }
        }

        private void Elimina(object sender, EventArgs e)
        {
            
            if (bindingSourcePersona.Current is Persona elimina)
            {
                DialogResult result = MessageBox.Show(this,
                    $"Confermi l'eliminazione di {elimina.Nome} {elimina.Cognome}?",
                    "Conferma",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    PersoneRepository.Delete(elimina);
                    CaricaLista();
                }
            }
        }

        private void FiltraListaPersone(object sender, EventArgs e)
        {
            if (cmbSportPF?.SelectedValue is int id)
            {
                CaricaLista(PersoneRepository.GetBySport(id));
            }
        }

    }
}
