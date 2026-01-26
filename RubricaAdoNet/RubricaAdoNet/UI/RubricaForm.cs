using RubricaAdoNet.DAO;
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
    public partial class RubricaForm : Form
    {
        private readonly List<Contatto> _listaContatti = [];
        public RubricaForm()
        {
            InitializeComponent();
            SetListaContatti();
            bindingSource1.DataSource = _listaContatti;
        }

        private void SetListaContatti()
        {
            _listaContatti.Clear();
            _listaContatti.AddRange(ContattiRepository.GetAll());
        }

        private void ReflectChanges()
        {
            bindingSource1.ResetBindings(false);
        }

        private void Nuovo()
        {
            Contatto nuovoContatto = new();
            ContattoForm form = new(nuovoContatto);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                if (!ContattiRepository.Insert(nuovoContatto))
                {
                    MessageBox.Show(
                        "Si è verificato un errore di scrittura",
                        "Attenzione",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                SetListaContatti();
                ReflectChanges();
            }
        }

        private void Modifica()
        {
            if (bindingSource1.Current is Contatto modifica)
            {
                Contatto clone = new();
                clone.CloneFrom(modifica);

                ContattoForm form = new(clone);
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    modifica.CloneFrom(clone);
                    // TODO: Inserire logica di db qui
                    ReflectChanges();
                }
            }
        }

        private void Elimina()
        {
            if (_listaContatti.Count == 0) { return; }

            if (bindingSource1.Current is Contatto selezionato)
            {
                string msg = $"Confermi di voler eliminare il contatto " +
                $"{selezionato.InfoContatto}";

                DialogResult dr = MessageBox.Show(
                    msg,
                    "Conferma",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dr == DialogResult.Yes)
                {
                    _listaContatti.Remove(selezionato);
                    ReflectChanges();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Nuovo();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Modifica();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Elimina();
        }

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuovo();
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifica();
        }

        private void eliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Elimina();
        }
    }
}
