namespace ModelForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lstContatti = new ListBox();
            bindingSource1 = new BindingSource(components);
            label2 = new Label();
            txtNome = new TextBox();
            txtCognome = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            btnSalva = new Button();
            btnPulisci = new Button();
            btnSvuota = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 33);
            label1.Name = "label1";
            label1.Size = new Size(174, 37);
            label1.TabIndex = 0;
            label1.Text = "Lista Contatti";
            // 
            // lstContatti
            // 
            lstContatti.DataSource = bindingSource1;
            lstContatti.DisplayMember = "Cognome";
            lstContatti.FormattingEnabled = true;
            lstContatti.ItemHeight = 37;
            lstContatti.Location = new Point(30, 90);
            lstContatti.Name = "lstContatti";
            lstContatti.Size = new Size(243, 337);
            lstContatti.TabIndex = 1;
            lstContatti.MouseDoubleClick += lstContatti_MouseDoubleClick;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.Contatto);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 33);
            label2.Name = "label2";
            label2.Size = new Size(90, 37);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(553, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(334, 43);
            txtNome.TabIndex = 3;
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(553, 107);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(334, 43);
            txtCognome.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 113);
            label3.Name = "label3";
            label3.Size = new Size(134, 37);
            label3.TabIndex = 4;
            label3.Text = "Cognome";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(553, 190);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(334, 43);
            txtTelefono.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(391, 196);
            label4.Name = "label4";
            label4.Size = new Size(118, 37);
            label4.TabIndex = 6;
            label4.Text = "Telefono";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(553, 278);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(334, 43);
            txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 284);
            label5.Name = "label5";
            label5.Size = new Size(82, 37);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(719, 373);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(168, 54);
            btnSalva.TabIndex = 10;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // btnPulisci
            // 
            btnPulisci.Location = new Point(510, 373);
            btnPulisci.Name = "btnPulisci";
            btnPulisci.Size = new Size(168, 54);
            btnPulisci.TabIndex = 11;
            btnPulisci.Text = "Pulisci";
            btnPulisci.UseVisualStyleBackColor = true;
            btnPulisci.Click += btnPulisci_Click;
            // 
            // btnSvuota
            // 
            btnSvuota.Location = new Point(305, 373);
            btnSvuota.Name = "btnSvuota";
            btnSvuota.Size = new Size(168, 54);
            btnSvuota.TabIndex = 12;
            btnSvuota.Text = "Svuota Lista";
            btnSvuota.UseVisualStyleBackColor = true;
            btnSvuota.Click += btnSvuota_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 448);
            Controls.Add(btnSvuota);
            Controls.Add(btnPulisci);
            Controls.Add(btnSalva);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtCognome);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(lstContatti);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstContatti;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtCognome;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private Button btnSalva;
        private Button btnPulisci;
        private Button btnSvuota;
        private BindingSource bindingSource1;
    }
}
