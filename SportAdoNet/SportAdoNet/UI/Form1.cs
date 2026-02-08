using SportAdoNet.DAO;
using SportAdoNet.Models;
using SportAdoNet.UI;

namespace SportAdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPersone_Click(object sender, EventArgs e)
        {
            PersoneForm form = new();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SportForm form = new();
            form.ShowDialog();
        }
    }
}
