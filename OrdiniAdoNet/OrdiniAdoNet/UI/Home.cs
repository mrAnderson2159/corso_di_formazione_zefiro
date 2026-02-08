using OrdiniAdoNet.UI.Clienti;
using OrdiniAdoNet.UI.Prodotti;
using OrdiniAdoNet.UI.Ordini;

namespace OrdiniAdoNet.UI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientiForm form = new();
            form.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProdottiForm form = new();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrdiniForm form = new();
            form.ShowDialog();
        }
    }
}
