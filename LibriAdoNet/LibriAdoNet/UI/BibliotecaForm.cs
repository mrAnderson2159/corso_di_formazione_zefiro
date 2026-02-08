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
    public partial class BibliotecaForm : Form
    {
        private readonly List<Libro> _listaLibri = [];
        public BibliotecaForm()
        {
            InitializeComponent();
            SetListaLibri();
            bindingSource1.DataSource = _listaLibri;
        }

        private void SetListaLibri(List<Libro>? newList = null)
        {
            _listaLibri.Clear();
            _listaLibri.AddRange(newList ?? LibriRepository.GetAll());
        }

        private void AggiornaInterfaccia()
        {
            bindingSource1.ResetBindings(false);
        }

        private void Nuovo(object sender, EventArgs e)
        {
            Libro newLibro = new();
            LibroForm form = new(newLibro);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.Cancel) { return; }

            int id = LibriRepository.Insert(newLibro);

            if (id == 0) { return; }

            newLibro.Id = id;
            _listaLibri.Add(newLibro);
            AggiornaInterfaccia();
        }

        private void Modifica(object sender, EventArgs e)
        {
            if (bindingSource1.Current is Libro modifica)
            {
                Libro clone = new();
                clone.CopyFrom(modifica);

                LibroForm form = new(clone);
                form.ShowDialog();

                if (form.DialogResult == DialogResult.Cancel) { return; }

                if (!LibriRepository.Update(modifica)) { return; }

                SetListaLibri();
                AggiornaInterfaccia();
            }
        }

        private void Elimina(object sender, EventArgs e)
        {
            if (bindingSource1.Current is Libro elimina)
            {
                string msg = $"Confermi di voler eliminare il libro {elimina.InfoLibro}?";

                bool confirm = MessageBox.Show(
                    msg,
                    "Conferma",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) == DialogResult.Yes;

                if (!confirm) { return; }

                if (!LibriRepository.Delete(elimina)) { return; }

                _listaLibri.Remove(elimina);
                AggiornaInterfaccia();
            }
        }

        private void RicercaPerTitolo(object sender, EventArgs e)
        {
            string titolo = txtCercaPerTitolo.Text;

            if (titolo.Length == 0)
            {
                SetListaLibri();
            } else
            {
                SetListaLibri(LibriRepository.SearchByTitle(titolo));
            }
            AggiornaInterfaccia();
        }

        private void RicercaPerAutore(object sender, EventArgs e)
        {
            string autore = txtCercaPerAutore.Text;

            if (autore.Length == 0)
            {
                SetListaLibri();
            }
            else
            {
                SetListaLibri(LibriRepository.SearchByAuthor(autore));
            }
            AggiornaInterfaccia();
        }
    }
}
