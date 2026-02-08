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
        }

        
    }
}
