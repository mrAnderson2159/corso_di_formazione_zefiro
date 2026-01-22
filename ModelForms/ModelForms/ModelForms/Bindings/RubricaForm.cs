using ModelForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelForms.Bindings
{
    public partial class RubricaForm : Form
    {
        List<Contatto> _listaContatti = [];
        public RubricaForm()
        {
            InitializeComponent();
            MockDati();
            bindingSource1.DataSource = _listaContatti;
        }

        private void MockDati()
        {
            Contatto c1 = new()
            {
                Nome = "Mario",
                Cognome = "Rossi",
                Email = "rossi.mario@google.com",
                NumeroTelefono = "1234567890"
            };
            Contatto c2 = new()
            {
                Nome = "Giulia",
                Cognome = "Bianchi",
                Email = "bianchi.giulia@yahoo.com",
                NumeroTelefono = "0987654321"
            };

            _listaContatti.Add(c1);
            _listaContatti.Add(c2);
        }

        private void ReflectChanges()
        {
            bindingSource1.ResetBindings(false);
        }

        private Contatto? OttieniSelezionato()
        {
            if (bindingSource1.Current is Contatto contattoSelezionato)
            {
                return contattoSelezionato;
            }
            else
            {
                MessageBox.Show(
                    "Nessun contatto selezionato",
                    "Attenzione",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return null;
            }
        }

        private void Nuovo()
        {
            Contatto nuovoContatto = new();
            DettaglioContattoForm form = new(nuovoContatto);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                _listaContatti.Insert(0, nuovoContatto);
                ReflectChanges();
            }
        }

        private void Modifica()
        {
            Contatto? contattoSelezionato = OttieniSelezionato();

            if (contattoSelezionato == null) { return; }

            DettaglioContattoForm form = new(contattoSelezionato);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                ReflectChanges();
            }
        }

        private void Elimina()
        {
            if (_listaContatti.Count == 0) { return; }

            Contatto? contattoSelezionato = OttieniSelezionato();

            if (contattoSelezionato == null) { return; }

            string msg = $"Confermi di voler eliminare il contatto " +
                $"{contattoSelezionato.NomeCompleto}";

            DialogResult dr = MessageBox.Show(
                msg,
                "Conferma",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr == DialogResult.Yes)
            {
                _listaContatti.Remove(contattoSelezionato);
                ReflectChanges();
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

        /*
        A proposito del ContextMenuStrip delle ListBox, dopo averlo
        sulla ListBox e averne definito le voci, bisogna andare
        sulle proprietà della Listbox e selezionarlo nell'omonimo menu.
        Si procederà poi a gestire gli eventi di click dei menu item
        selezionando il fulmine di eventi in proprietà.
        */

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