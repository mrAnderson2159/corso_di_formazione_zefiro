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
    public partial class LibroForm : Form
    {
        private readonly Libro _source;

        public LibroForm(Libro libro)
        {
            InitializeComponent();
            _source = libro;
            bindingSource1.DataSource = _source;
        }

       
    }
}
