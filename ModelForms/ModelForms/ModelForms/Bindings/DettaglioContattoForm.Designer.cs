namespace ModelForms.Bindings
{
    partial class DettaglioContattoForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            bindingSource1 = new BindingSource(components);
            txtCognome = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            btnCancel = new Button();
            btnSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 48);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 146);
            label2.Name = "label2";
            label2.Size = new Size(103, 30);
            label2.TabIndex = 1;
            label2.Text = "Cognome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 252);
            label3.Name = "label3";
            label3.Size = new Size(63, 30);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 356);
            label4.Name = "label4";
            label4.Size = new Size(92, 30);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // txtNome
            // 
            txtNome.DataBindings.Add(new Binding("Text", bindingSource1, "Nome", true));
            txtNome.Location = new Point(183, 45);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(259, 35);
            txtNome.TabIndex = 4;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.Contatto);
            // 
            // txtCognome
            // 
            txtCognome.DataBindings.Add(new Binding("Text", bindingSource1, "Cognome", true));
            txtCognome.Location = new Point(183, 143);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(259, 35);
            txtCognome.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.DataBindings.Add(new Binding("Text", bindingSource1, "Email", true));
            txtEmail.Location = new Point(183, 249);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(259, 35);
            txtEmail.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.DataBindings.Add(new Binding("Text", bindingSource1, "NumeroTelefono", true));
            txtTelefono.Location = new Point(183, 353);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(259, 35);
            txtTelefono.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 192, 192);
            btnCancel.Location = new Point(43, 473);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(141, 40);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Annulla";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(192, 255, 192);
            btnSubmit.ForeColor = SystemColors.ControlText;
            btnSubmit.Location = new Point(301, 473);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(141, 40);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Salva";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // DettaglioContattoForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 547);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtCognome);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DettaglioContattoForm";
            Text = "Contatto";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtCognome;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private Button btnCancel;
        private Button btnSubmit;
        private BindingSource bindingSource1;
    }
}