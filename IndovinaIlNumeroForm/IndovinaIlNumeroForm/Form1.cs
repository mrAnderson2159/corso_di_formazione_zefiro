using IndovinaIlNumeroForm.src;

namespace IndovinaIlNumeroForm
{
    public partial class Form1 : Form
    {
        private static readonly Logica _logic = new();
        private static readonly List<int> _listTentativi = [];

        public Form1()
        {
            InitializeComponent();
            Azzera();

            lblGiocata.ForeColor = Color.BlueViolet;
        }

        private void Azzera()
        {
            _listTentativi.Clear();
            _logic.Reset();
            btnAzzera.Enabled = false;
            btnGioca.Enabled = true;
            btnSettings.Enabled = false;
            lblGiocata.Text = String.Empty;
            txtGiocata.Text = String.Empty;
            txtGiocata.Focus();
            lstTentativi.Items.Clear();
            SetLblInsertNum();
        }

        private void SetLblInsertNum()
        {
            int min = _logic.Minimo;
            int max = _logic.Massimo - 1;
            lblInsertNum.Text = $"Inserisci un numero tra {min} e {max}";
        }

        private void Gioca()
        {
            int? input = _logic.ValidateInput(txtGiocata.Text);

            if (!input.HasValue)
            {
                return;
            }

            int numInput = input.Value;

            EnumEsito esito = _logic.ControllaNumero(numInput);
            string esitoText = Logica.Esito(esito);
            AggiungiTentativo(numInput, esitoText);

            if (esito == EnumEsito.Uguale)
            {
                
                lblGiocata.Text = _logic.CommentoVittoria();
                btnAzzera.Enabled = true;
                btnGioca.Enabled = false;
                btnSettings.Enabled = true;
            }
            else
            {
                lblGiocata.Text = string.Empty;
            }

            txtGiocata.SelectAll();
            txtGiocata.Focus();
        }

        private void AggiungiTentativo(int tentativo, string esito)
        {
            _listTentativi.Add(tentativo);
            lstTentativi.Items.Insert(0, $"{tentativo} - {esito}");
        }

        private void btnGioca_Click(object sender, EventArgs e)
        {
            Gioca();
        }

        private void btnAzzera_Click(object sender, EventArgs e)
        {
            Azzera();
        }

        private void txtGiocata_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Gioca();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form settings = new Form2(_logic);
            settings.ShowDialog();

        }
    }
}
