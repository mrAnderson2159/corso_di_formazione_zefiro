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

        private void SetListaContatti(List<Contatto>? newList = null)
        {
            _listaContatti.Clear();
            _listaContatti.AddRange(newList ?? ContattiRepository.GetAll());
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
                int id = ContattiRepository.Insert(nuovoContatto);

                if (id == 0)
                {
                    MessageBox.Show(
                        "Si è verificato un errore di scrittura",
                        "Attenzione",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                nuovoContatto.Id = id;
                _listaContatti.Add(nuovoContatto);
                ReflectChanges();
            }
        }

        private void Modifica()
        {
            if (bindingSource1.Current is Contatto modifica)
            {
                Contatto clone = new();
                modifica.CloneTo(clone);

                ContattoForm form = new(clone);
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    if (!ContattiRepository.Update(clone))
                    {
                        MessageBox.Show(
                            "Nessun dato è stato modificato",
                            "Informazione",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        return;
                    }

                    modifica.CloneFrom(clone);
                    ReflectChanges();
                }
            }
        }

        private void Elimina(object sender, EventArgs e)
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
                    if (!ContattiRepository.Delete(selezionato))
                    {
                        return;
                    }
                    _listaContatti.Remove(selezionato);
                    ReflectChanges();
                }
            }
        }

        private void CercaPerCognome()
        {
            if (txtCercaCognome.Text.Length == 0)
            {
                SetListaContatti();
            }
            else
            {
                SetListaContatti(ContattiRepository.GetByCognome(txtCercaCognome.Text));
            }

            ReflectChanges();
        }

        private void CercaPerNumero()
        {
            if (txtCercaPerNumero.Text.Length == 0)
            {
                SetListaContatti();
            }
            else
            {
                SetListaContatti(ContattiRepository.GetByNumero(txtCercaPerNumero.Text));
            }

            ReflectChanges();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Nuovo();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Modifica();
        }

        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuovo();
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifica();
        }

        private void txtCercaCognome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CercaPerCognome();
            }
        }

        private void txtCercaPerNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CercaPerNumero();
            }
        }
    }
}
