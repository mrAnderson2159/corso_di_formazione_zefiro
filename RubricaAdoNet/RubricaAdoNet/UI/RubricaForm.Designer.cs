namespace RubricaAdoNet.UI
{
    partial class RubricaForm
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
            lstContatti = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            nuovoToolStripMenuItem = new ToolStripMenuItem();
            modificaToolStripMenuItem = new ToolStripMenuItem();
            eliminaToolStripMenuItem = new ToolStripMenuItem();
            bindingSource1 = new BindingSource(components);
            btnNew = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            txtCercaCognome = new TextBox();
            txtCercaPerNumero = new TextBox();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lstContatti
            // 
            lstContatti.ContextMenuStrip = contextMenuStrip1;
            lstContatti.DataSource = bindingSource1;
            lstContatti.DisplayMember = "InfoContatto";
            lstContatti.FormattingEnabled = true;
            lstContatti.Location = new Point(12, 142);
            lstContatti.Name = "lstContatti";
            lstContatti.Size = new Size(397, 424);
            lstContatti.TabIndex = 0;
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
            nuovoToolStripMenuItem.Click += nuovoToolStripMenuItem_Click;
            // 
            // modificaToolStripMenuItem
            // 
            modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            modificaToolStripMenuItem.Size = new Size(167, 36);
            modificaToolStripMenuItem.Text = "Modifica";
            modificaToolStripMenuItem.Click += modificaToolStripMenuItem_Click;
            // 
            // eliminaToolStripMenuItem
            // 
            eliminaToolStripMenuItem.Name = "eliminaToolStripMenuItem";
            eliminaToolStripMenuItem.Size = new Size(167, 36);
            eliminaToolStripMenuItem.Text = "Elimina";
            eliminaToolStripMenuItem.Click += Elimina;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.Contatto);
            // 
            // btnNew
            // 
            btnNew.Location = new Point(487, 142);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(199, 98);
            btnNew.TabIndex = 1;
            btnNew.Text = "Nuovo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(487, 468);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(199, 98);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Elimina";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += Elimina;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(487, 304);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(199, 98);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Modifica";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtCercaCognome
            // 
            txtCercaCognome.Location = new Point(12, 12);
            txtCercaCognome.Name = "txtCercaCognome";
            txtCercaCognome.PlaceholderText = "Cerca Cognome...";
            txtCercaCognome.Size = new Size(397, 35);
            txtCercaCognome.TabIndex = 4;
            txtCercaCognome.KeyDown += txtCercaCognome_KeyDown;
            // 
            // txtCercaPerNumero
            // 
            txtCercaPerNumero.Location = new Point(12, 72);
            txtCercaPerNumero.Name = "txtCercaPerNumero";
            txtCercaPerNumero.PlaceholderText = "Cerca Numero...";
            txtCercaPerNumero.Size = new Size(397, 35);
            txtCercaPerNumero.TabIndex = 5;
            txtCercaPerNumero.KeyDown += txtCercaPerNumero_KeyDown;
            // 
            // RubricaForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 618);
            Controls.Add(txtCercaPerNumero);
            Controls.Add(txtCercaCognome);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(lstContatti);
            Name = "RubricaForm";
            Text = "RubricaForm";
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstContatti;
        private Button btnNew;
        private Button btnDelete;
        private Button btnEdit;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem nuovoToolStripMenuItem;
        private ToolStripMenuItem modificaToolStripMenuItem;
        private ToolStripMenuItem eliminaToolStripMenuItem;
        private BindingSource bindingSource1;
        private TextBox txtCercaCognome;
        private TextBox txtCercaPerNumero;
    }
}