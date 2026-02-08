namespace LibriAdoNet.UI
{
    partial class LibroForm
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
            bindingSource1 = new BindingSource(components);
            txtTitolo = new TextBox();
            txtAutore = new TextBox();
            txtCategoria = new TextBox();
            txtFila = new TextBox();
            txtScaffale = new TextBox();
            cbxEsaurito = new CheckBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            nudNumeroPagine = new NumericUpDown();
            lblPagine = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumeroPagine).BeginInit();
            SuspendLayout();
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.Libro);
            // 
            // txtTitolo
            // 
            txtTitolo.DataBindings.Add(new Binding("Text", bindingSource1, "Titolo", true));
            txtTitolo.Location = new Point(12, 12);
            txtTitolo.Name = "txtTitolo";
            txtTitolo.PlaceholderText = "Titolo...";
            txtTitolo.Size = new Size(659, 35);
            txtTitolo.TabIndex = 0;
            // 
            // txtAutore
            // 
            txtAutore.DataBindings.Add(new Binding("Text", bindingSource1, "Autore", true));
            txtAutore.Location = new Point(12, 82);
            txtAutore.Name = "txtAutore";
            txtAutore.PlaceholderText = "Autore...";
            txtAutore.Size = new Size(659, 35);
            txtAutore.TabIndex = 1;
            // 
            // txtCategoria
            // 
            txtCategoria.DataBindings.Add(new Binding("Text", bindingSource1, "Categoria", true));
            txtCategoria.Location = new Point(12, 152);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.PlaceholderText = "Categoria...";
            txtCategoria.Size = new Size(659, 35);
            txtCategoria.TabIndex = 2;
            // 
            // txtFila
            // 
            txtFila.DataBindings.Add(new Binding("Text", bindingSource1, "Fila", true));
            txtFila.Location = new Point(12, 222);
            txtFila.Name = "txtFila";
            txtFila.PlaceholderText = "Fila...";
            txtFila.Size = new Size(305, 35);
            txtFila.TabIndex = 5;
            // 
            // txtScaffale
            // 
            txtScaffale.DataBindings.Add(new Binding("Text", bindingSource1, "Scaffale", true));
            txtScaffale.Location = new Point(367, 222);
            txtScaffale.Name = "txtScaffale";
            txtScaffale.PlaceholderText = "Scaffale...";
            txtScaffale.Size = new Size(305, 35);
            txtScaffale.TabIndex = 6;
            // 
            // cbxEsaurito
            // 
            cbxEsaurito.AutoSize = true;
            cbxEsaurito.DataBindings.Add(new Binding("Checked", bindingSource1, "Esaurito", true));
            cbxEsaurito.Location = new Point(370, 292);
            cbxEsaurito.Name = "cbxEsaurito";
            cbxEsaurito.Size = new Size(113, 34);
            cbxEsaurito.TabIndex = 7;
            cbxEsaurito.Text = "Esaurito";
            cbxEsaurito.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(367, 427);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(306, 60);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Salva";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 427);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(305, 60);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Annulla";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // nudNumeroPagine
            // 
            nudNumeroPagine.DataBindings.Add(new Binding("Value", bindingSource1, "NumeroPagine", true));
            nudNumeroPagine.Location = new Point(226, 292);
            nudNumeroPagine.Maximum = new decimal(new int[] { 8000, 0, 0, 0 });
            nudNumeroPagine.Name = "nudNumeroPagine";
            nudNumeroPagine.Size = new Size(91, 35);
            nudNumeroPagine.TabIndex = 10;
            nudNumeroPagine.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // lblPagine
            // 
            lblPagine.AutoSize = true;
            lblPagine.Location = new Point(12, 294);
            lblPagine.Name = "lblPagine";
            lblPagine.Size = new Size(183, 30);
            lblPagine.TabIndex = 11;
            lblPagine.Text = "Numero Di Pagine";
            // 
            // LibroForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 559);
            Controls.Add(lblPagine);
            Controls.Add(nudNumeroPagine);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(cbxEsaurito);
            Controls.Add(txtScaffale);
            Controls.Add(txtFila);
            Controls.Add(txtCategoria);
            Controls.Add(txtAutore);
            Controls.Add(txtTitolo);
            Name = "LibroForm";
            Text = "LibroForm";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumeroPagine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private TextBox txtTitolo;
        private TextBox txtAutore;
        private TextBox txtCategoria;
        private TextBox txtFila;
        private TextBox txtScaffale;
        private CheckBox cbxEsaurito;
        private Button btnSubmit;
        private Button btnCancel;
        private NumericUpDown nudNumeroPagine;
        private Label lblPagine;
    }
}