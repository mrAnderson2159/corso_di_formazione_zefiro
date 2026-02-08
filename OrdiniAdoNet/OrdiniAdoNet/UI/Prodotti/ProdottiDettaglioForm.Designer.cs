namespace OrdiniAdoNet.UI.Prodotti
{
    partial class ProdottiDettaglioForm
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
            txtName = new TextBox();
            bindingSourceProductDTO = new BindingSource(components);
            label1 = new Label();
            nudPrice = new NumericUpDown();
            cbxAvailable = new CheckBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSourceProductDTO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.DataBindings.Add(new Binding("Text", bindingSourceProductDTO, "Nome", true));
            txtName.Location = new Point(12, 12);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nome Prodotto...";
            txtName.Size = new Size(668, 48);
            txtName.TabIndex = 0;
            // 
            // bindingSourceProductDTO
            // 
            bindingSourceProductDTO.DataSource = typeof(DTOs.ProdottoDTO);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 94);
            label1.Name = "label1";
            label1.Size = new Size(108, 42);
            label1.TabIndex = 1;
            label1.Text = "Prezzo";
            // 
            // nudPrice
            // 
            nudPrice.DataBindings.Add(new Binding("Value", bindingSourceProductDTO, "Prezzo", true));
            nudPrice.DecimalPlaces = 2;
            nudPrice.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrice.Location = new Point(429, 92);
            nudPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(251, 48);
            nudPrice.TabIndex = 2;
            // 
            // cbxAvailable
            // 
            cbxAvailable.AutoSize = true;
            cbxAvailable.DataBindings.Add(new Binding("Checked", bindingSourceProductDTO, "InStock", true));
            cbxAvailable.Location = new Point(12, 172);
            cbxAvailable.Name = "cbxAvailable";
            cbxAvailable.Size = new Size(199, 46);
            cbxAvailable.TabIndex = 3;
            cbxAvailable.Text = "Disponibile";
            cbxAvailable.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(429, 491);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(251, 70);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Salva";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 491);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(251, 70);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Annulla";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(388, 94);
            label2.Name = "label2";
            label2.Size = new Size(35, 42);
            label2.TabIndex = 6;
            label2.Text = "€";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 254);
            label3.Name = "label3";
            label3.Size = new Size(358, 42);
            label3.TabIndex = 7;
            label3.Text = "Quantità Totale Ordinata";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 334);
            label4.Name = "label4";
            label4.Size = new Size(350, 42);
            label4.TabIndex = 8;
            label4.Text = "Importo Totale Ordinato";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSourceProductDTO, "QuantitaTotaleOrdinata", true));
            textBox1.Enabled = false;
            textBox1.Location = new Point(429, 252);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 48);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSourceProductDTO, "ImportoTotaleOrdinato", true));
            textBox2.Enabled = false;
            textBox2.Location = new Point(429, 332);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(251, 48);
            textBox2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(388, 334);
            label6.Name = "label6";
            label6.Size = new Size(35, 42);
            label6.TabIndex = 12;
            label6.Text = "€";
            // 
            // ProdottiDettaglioForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 577);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(cbxAvailable);
            Controls.Add(nudPrice);
            Controls.Add(label1);
            Controls.Add(txtName);
            Font = new Font("Segoe UI", 13F);
            Margin = new Padding(4);
            Name = "ProdottiDettaglioForm";
            Text = "Dettagli Prodotto";
            ((System.ComponentModel.ISupportInitialize)bindingSourceProductDTO).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private NumericUpDown nudPrice;
        private CheckBox cbxAvailable;
        private BindingSource bindingSourceProductDTO;
        private Button btnConfirm;
        private Button btnCancel;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label6;
    }
}