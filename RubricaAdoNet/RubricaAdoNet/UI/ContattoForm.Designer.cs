namespace RubricaAdoNet.UI
{
    partial class ContattoForm
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
            txtNome = new TextBox();
            bindingSource1 = new BindingSource(components);
            txtCognome = new TextBox();
            txtEmail = new TextBox();
            txtNumeroCellulare = new TextBox();
            txtNumeroFisso = new TextBox();
            textBox6 = new TextBox();
            txtCitta = new TextBox();
            label1 = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.DataBindings.Add(new Binding("Text", bindingSource1, "Nome", true));
            txtNome.Location = new Point(12, 12);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "*Nome...";
            txtNome.Size = new Size(607, 35);
            txtNome.TabIndex = 0;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.Contatto);
            // 
            // txtCognome
            // 
            txtCognome.DataBindings.Add(new Binding("Text", bindingSource1, "Cognome", true));
            txtCognome.Location = new Point(12, 82);
            txtCognome.Name = "txtCognome";
            txtCognome.PlaceholderText = "*Cognome...";
            txtCognome.Size = new Size(607, 35);
            txtCognome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.DataBindings.Add(new Binding("Text", bindingSource1, "Email", true));
            txtEmail.Location = new Point(12, 152);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email...";
            txtEmail.Size = new Size(607, 35);
            txtEmail.TabIndex = 2;
            // 
            // txtNumeroCellulare
            // 
            txtNumeroCellulare.DataBindings.Add(new Binding("Text", bindingSource1, "NumeroCellulare", true));
            txtNumeroCellulare.Location = new Point(12, 222);
            txtNumeroCellulare.Name = "txtNumeroCellulare";
            txtNumeroCellulare.PlaceholderText = "Numero di cellulare...";
            txtNumeroCellulare.Size = new Size(607, 35);
            txtNumeroCellulare.TabIndex = 3;
            // 
            // txtNumeroFisso
            // 
            txtNumeroFisso.DataBindings.Add(new Binding("Text", bindingSource1, "NumeroFisso", true));
            txtNumeroFisso.Location = new Point(12, 292);
            txtNumeroFisso.Name = "txtNumeroFisso";
            txtNumeroFisso.PlaceholderText = "Numero Fisso...";
            txtNumeroFisso.Size = new Size(607, 35);
            txtNumeroFisso.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(12, 362);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Data di Nascita...";
            textBox6.Size = new Size(607, 35);
            textBox6.TabIndex = 5;
            // 
            // txtCitta
            // 
            txtCitta.DataBindings.Add(new Binding("Text", bindingSource1, "Citta", true));
            txtCitta.Location = new Point(12, 442);
            txtCitta.Name = "txtCitta";
            txtCitta.PlaceholderText = "Città...";
            txtCitta.Size = new Size(607, 35);
            txtCitta.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 6F);
            label1.Location = new Point(15, 512);
            label1.Name = "label1";
            label1.Size = new Size(352, 19);
            label1.TabIndex = 9;
            label1.Text = "*I campi contrassegnati da un asterisco sono obbligatori";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(418, 591);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(201, 55);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Salva";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(15, 591);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(201, 55);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Annulla";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ContattoForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 716);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Controls.Add(txtCitta);
            Controls.Add(textBox6);
            Controls.Add(txtNumeroFisso);
            Controls.Add(txtNumeroCellulare);
            Controls.Add(txtEmail);
            Controls.Add(txtCognome);
            Controls.Add(txtNome);
            Name = "ContattoForm";
            Text = "ContattoForm";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCognome;
        private TextBox txtEmail;
        private TextBox txtNumeroCellulare;
        private TextBox txtNumeroFisso;
        private TextBox textBox6;
        private TextBox txtCitta;
        private Label label1;
        private Button btnSubmit;
        private Button btnCancel;
        private BindingSource bindingSource1;
    }
}