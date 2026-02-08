namespace LibriAdoNet.UI
{
    partial class BibliotecaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtCercaPerTitolo = new TextBox();
            txtCercaPerAutore = new TextBox();
            lstLibri = new ListBox();
            bindingSource1 = new BindingSource(components);
            btnNew = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            nuovoToolStripMenuItem = new ToolStripMenuItem();
            modificaToolStripMenuItem = new ToolStripMenuItem();
            eliminaToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCercaPerTitolo
            // 
            txtCercaPerTitolo.Location = new Point(12, 12);
            txtCercaPerTitolo.Name = "txtCercaPerTitolo";
            txtCercaPerTitolo.PlaceholderText = "Ricerca per Titolo...";
            txtCercaPerTitolo.Size = new Size(631, 35);
            txtCercaPerTitolo.TabIndex = 0;
            txtCercaPerTitolo.TextChanged += RicercaPerTitolo;
            // 
            // txtCercaPerAutore
            // 
            txtCercaPerAutore.Location = new Point(12, 82);
            txtCercaPerAutore.Name = "txtCercaPerAutore";
            txtCercaPerAutore.PlaceholderText = "Ricerca per Autore...";
            txtCercaPerAutore.Size = new Size(631, 35);
            txtCercaPerAutore.TabIndex = 1;
            txtCercaPerAutore.TextChanged += RicercaPerAutore;
            // 
            // lstLibri
            // 
            lstLibri.DataSource = bindingSource1;
            lstLibri.DisplayMember = "FullInfoLibro";
            lstLibri.FormattingEnabled = true;
            lstLibri.Location = new Point(12, 162);
            lstLibri.Name = "lstLibri";
            lstLibri.Size = new Size(631, 484);
            lstLibri.TabIndex = 2;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.Libro);
            // 
            // btnNew
            // 
            btnNew.Location = new Point(714, 162);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(268, 91);
            btnNew.TabIndex = 3;
            btnNew.Text = "Nuovo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += Nuovo;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(714, 555);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(268, 91);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Elimina";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += Elimina;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(714, 358);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(268, 91);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Modifica";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += Modifica;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(28, 28);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { nuovoToolStripMenuItem, modificaToolStripMenuItem, eliminaToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(168, 112);
            // 
            // nuovoToolStripMenuItem
            // 
            nuovoToolStripMenuItem.Name = "nuovoToolStripMenuItem";
            nuovoToolStripMenuItem.Size = new Size(167, 36);
            nuovoToolStripMenuItem.Text = "Nuovo";
            nuovoToolStripMenuItem.Click += Nuovo;
            // 
            // modificaToolStripMenuItem
            // 
            modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            modificaToolStripMenuItem.Size = new Size(167, 36);
            modificaToolStripMenuItem.Text = "Modifica";
            modificaToolStripMenuItem.Click += Modifica;
            // 
            // eliminaToolStripMenuItem
            // 
            eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            eliminaToolStripMenuItem.Size = new Size(167, 36);
            eliminaToolStripMenuItem.Text = "Elimina";
            eliminaToolStripMenuItem.Click += Elimina;
            // 
            // BibliotecaForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 670);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(lstLibri);
            Controls.Add(txtCercaPerAutore);
            Controls.Add(txtCercaPerTitolo);
            Name = "BibliotecaForm";
            Text = "BibliotecaForm";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCercaPerTitolo;
        private TextBox txtCercaPerAutore;
        private ListBox lstLibri;
        private Button btnNew;
        private Button btnDelete;
        private Button btnUpdate;
        private BindingSource bindingSource1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem nuovoToolStripMenuItem;
        private ToolStripMenuItem modificaToolStripMenuItem;
        private ToolStripMenuItem eliminaToolStripMenuItem;
    }
}