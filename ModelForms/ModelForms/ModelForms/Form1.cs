using ModelForms.Models;

namespace ModelForms
{
    public partial class Form1 : Form
    {
        //ci servirà sicuramente una lista di contatti
        private readonly List<Contatto> _listContatti = [];

        public Form1()
        {
            InitializeComponent();
            //MOCK DEI DATI cioè costruisco dei dati 
            //"a mano" che serviranno per provare 
            //la mia user interface
            MockDati();
            //dopo aver chiamato questo metodo la mia _listContatti
            //contiene due elementi, se voglio visualizzare 
            //il cognome dei contatti esistenti nella list 
            //sulla ListBox li scorro e aggiungo il valore della 
            //prop Cognome agli Item della ListBox
            //foreach (var contatto in _listContatti)
            //{
            //    lstContatti.Items.Add(contatto.Cognome);
            //}
            //usando il bindingSource, dopo aver impostato le proprietà
            //dalla finestra di progettazione dobbiamo dire al 
            //bindingSource quali sono CONCRETAMENTE gli oggetti di tipo
            //Contatto che saprà fornire alla UI
            bindingSource1.DataSource = _listContatti;
        }

        private void MockDati()
        {
            //costruisco un oggetto Contatto 
            //e lo aggiungo alla lista
            Contatto c1 = new Contatto();
            c1.Nome = "Mario";
            c1.Cognome = "Rossi";
            c1.NumeroTelefono = "075123456";
            c1.Email = "mario@rossi.it";
            _listContatti.Add(c1);
            //C# ci permette di costruire delle 
            //istanze "al volo" 
            Contatto c2 = new Contatto
            {
                Nome = "Veronica",
                Cognome = "Gialli",
                NumeroTelefono = "33512345678",
                Email = "veronica@gialli.it"
            };
            _listContatti.Add(c2);
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            //se voglio che i dati delle textbox servano a costruire un 
            //contatto lo devo fare a mano
            Contatto contatto = new Contatto();
            contatto.Nome = txtNome.Text;
            contatto.Cognome = txtCognome.Text;
            contatto.NumeroTelefono = txtTelefono.Text;
            contatto.Email = txtEmail.Text;
            //Se voglio che il mio contatto faccia parte della 
            //listContatti ce lo aggiungo
            _listContatti.Add(contatto);
            //visto che usiamo un bindingSource lo devo informare
            //che è cambiato qualcosa nell'oggetto che alimenta 
            //il suo DataSource
            bindingSource1.ResetBindings(false);
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            txtNome.ResetText();
            txtCognome.Text = String.Empty;
            txtTelefono.ResetText();
            txtEmail.ResetText();
            txtNome.Focus();
        }

        private void btnSvuota_Click(object sender, EventArgs e)
        {
            _listContatti.Clear();
            //informo il bindigSource che è cambiato qualcosa
            bindingSource1.ResetBindings(false);
        }

        private void lstContatti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //chi regola i dati mostrati nella ListBox 
            //è il mio bindingsource, quindi se voglio l'elemento 
            //della lista su cui ho fatto doppio click sfrutto 
            //la property Current di bindingSource1
            //OPPORTUNAMENTE CASTATA
            //ora se selezionato è diverso da null vuol dire che 
            //è stato fatto doppio click su un oggetto Contatto
            if (bindingSource1.Current is Contatto selezionato)
            {
                //le property Text delle TextBox sono assegnabili anche 
                //da codice, quindi se voglio vedere nelle mie TextBox
                //i dati del Contatto selezionato li assegno
                txtNome.Text = selezionato.Nome;
                txtCognome.Text = selezionato.Cognome;
                txtTelefono.Text = selezionato.NumeroTelefono;
                txtEmail.Text = selezionato.Email;
            }
        }
    }
}
