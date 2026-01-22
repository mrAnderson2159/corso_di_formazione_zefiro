namespace ModelForms.Bindings
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
            btnEdit = new Button();
            btnDelete = new Button();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lstContatti
            // 
            lstContatti.ContextMenuStrip = contextMenuStrip1;
            lstContatti.DataSource = bindingSource1;
            lstContatti.DisplayMember = "NomeCompleto";
            lstContatti.FormattingEnabled = true;
            lstContatti.ItemHeight = 30;
            lstContatti.Location = new Point(27, 31);
            lstContatti.Name = "lstContatti";
            lstContatti.Size = new Size(333, 394);
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
            eliminaToolStripMenuItem.Click += eliminaToolStripMenuItem_Click;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.Contatto);
            // 
            // btnNew
            // 
            btnNew.Location = new Point(403, 31);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(216, 65);
            btnNew.TabIndex = 1;
            btnNew.Text = "Nuovo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(403, 129);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(216, 65);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Modifica";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(403, 231);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(216, 65);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Elimina";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // RubricaForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(lstContatti);
            Name = "RubricaForm";
            Text = "RubricaForm";
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstContatti;
        private Button btnNew;
        private Button btnEdit;
        private Button btnDelete;
        private BindingSource bindingSource1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem nuovoToolStripMenuItem;
        private ToolStripMenuItem modificaToolStripMenuItem;
        private ToolStripMenuItem eliminaToolStripMenuItem;
    }
}