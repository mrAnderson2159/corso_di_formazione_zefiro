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
        }

        private void Azzera()
        {
            _listTentativi.Clear();
            _logic.Reset();
            btnAzzera.Enabled = false;
            btnGioca.Enabled = true;
            txtGiocata.Text = String.Empty;
            lblGiocata.Text = String.Empty;
            lblListTentativi.Text = String.Empty;
            txtGiocata.Focus();
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
            string esitoText = _logic.Esito(esito);

            AggiungiTentativo(numInput);

            if (esito == EnumEsito.Uguale)
            {
                lblGiocata.ForeColor = Color.BlueViolet;
                btnAzzera.Enabled = true;
                btnGioca.Enabled = false;
            }
            else
            {
                lblGiocata.ForeColor = Color.Black;
            }

            lblGiocata.Text = esitoText;
            txtGiocata.SelectAll();
            txtGiocata.Focus();
        }

        private void AggiungiTentativo(int tentativo)
        {
            _listTentativi.Add(tentativo);
            lblListTentativi.Text = string.Join(", ", _listTentativi);
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
