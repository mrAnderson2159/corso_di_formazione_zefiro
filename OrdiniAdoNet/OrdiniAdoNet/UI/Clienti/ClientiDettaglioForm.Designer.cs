namespace OrdiniAdoNet.UI.Clienti
{
    partial class ClientiDettaglioForm
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
            bindingSourceClientDTO = new BindingSource(components);
            txtSurname = new TextBox();
            txtCodiceFiscale = new TextBox();
            txtPartitaIVA = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            dtpSubscription = new DateTimePicker();
            label1 = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtOrdiniTotali = new TextBox();
            txtImportoTotale = new TextBox();
            txtDataPrimoOrdine = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSourceClientDTO).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.DataBindings.Add(new Binding("Text", bindingSourceClientDTO, "Nome", true));
            txtName.Location = new Point(12, 12);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nome...";
            txtName.Size = new Size(770, 48);
            txtName.TabIndex = 0;
            // 
            // bindingSourceClientDTO
            // 
            bindingSourceClientDTO.DataSource = typeof(DTOs.ClienteDTO);
            // 
            // txtSurname
            // 
            txtSurname.DataBindings.Add(new Binding("Text", bindingSourceClientDTO, "Cognome", true));
            txtSurname.Location = new Point(12, 92);
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "Cognome...";
            txtSurname.Size = new Size(770, 48);
            txtSurname.TabIndex = 1;
            // 
            // txtCodiceFiscale
            // 
            txtCodiceFiscale.DataBindings.Add(new Binding("Text", bindingSourceClientDTO, "CodiceFiscale", true));
            txtCodiceFiscale.Location = new Point(12, 172);
            txtCodiceFiscale.Name = "txtCodiceFiscale";
            txtCodiceFiscale.PlaceholderText = "Codice Fiscale...";
            txtCodiceFiscale.Size = new Size(770, 48);
            txtCodiceFiscale.TabIndex = 2;
            // 
            // txtPartitaIVA
            // 
            txtPartitaIVA.DataBindings.Add(new Binding("Text", bindingSourceClientDTO, "PartitaIva", true));
            txtPartitaIVA.Location = new Point(12, 252);
            txtPartitaIVA.Name = "txtPartitaIVA";
            txtPartitaIVA.PlaceholderText = "Partita IVA...";
            txtPartitaIVA.Size = new Size(770, 48);
            txtPartitaIVA.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.DataBindings.Add(new Binding("Text", bindingSourceClientDTO, "Email", true));
            txtEmail.Location = new Point(12, 332);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email...";
            txtEmail.Size = new Size(770, 48);
            txtEmail.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.DataBindings.Add(new Binding("Text", bindingSourceClientDTO, "Telefono", true));
            txtPhone.Location = new Point(12, 412);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Telefono...";
            txtPhone.Size = new Size(770, 48);
            txtPhone.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.DataBindings.Add(new Binding("Text", bindingSourceClientDTO, "Indirizzo", true));
            txtAddress.Location = new Point(12, 492);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Indirizzo...";
            txtAddress.Size = new Size(770, 48);
            txtAddress.TabIndex = 6;
            // 
            // dtpSubscription
            // 
            dtpSubscription.DataBindings.Add(new Binding("Value", bindingSourceClientDTO, "DataIscrizione", true));
            dtpSubscription.Format = DateTimePickerFormat.Short;
            dtpSubscription.Location = new Point(457, 572);
            dtpSubscription.Name = "dtpSubscription";
            dtpSubscription.Size = new Size(325, 48);
            dtpSubscription.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 572);
            label1.Name = "label1";
            label1.Size = new Size(276, 42);
            label1.TabIndex = 8;
            label1.Text = "Data Registrazione";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(457, 958);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(319, 63);
            btnConfirm.TabIndex = 9;
            btnConfirm.Text = "Salva";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 958);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(319, 63);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Annulla";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 658);
            label2.Name = "label2";
            label2.Size = new Size(186, 42);
            label2.TabIndex = 11;
            label2.Text = "Ordini Totali";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 742);
            label3.Name = "label3";
            label3.Size = new Size(313, 42);
            label3.TabIndex = 12;
            label3.Text = "Importo Totale Ordini";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 832);
            label4.Name = "label4";
            label4.Size = new Size(274, 42);
            label4.TabIndex = 13;
            label4.Text = "Data Primo Ordine";
            // 
            // txtOrdiniTotali
            // 
            txtOrdiniTotali.DataBindings.Add(new Binding("Text", bindingSourceClientDTO, "OrdiniTotali", true));
            txtOrdiniTotali.Enabled = false;
            txtOrdiniTotali.Location = new Point(457, 655);
            txtOrdiniTotali.Name = "txtOrdiniTotali";
            txtOrdiniTotali.Size = new Size(319, 48);
            txtOrdiniTotali.TabIndex = 14;
            // 
            // txtImportoTotale
            // 
            txtImportoTotale.DataBindings.Add(new Binding("Text", bindingSourceClientDTO, "ImportoTotaleOrdinato", true));
            txtImportoTotale.Enabled = false;
            txtImportoTotale.Location = new Point(457, 739);
            txtImportoTotale.Name = "txtImportoTotale";
            txtImportoTotale.Size = new Size(319, 48);
            txtImportoTotale.TabIndex = 15;
            // 
            // txtDataPrimoOrdine
            // 
            txtDataPrimoOrdine.DataBindings.Add(new Binding("Text", bindingSourceClientDTO, "DataPrimoOrdine", true));
            txtDataPrimoOrdine.Enabled = false;
            txtDataPrimoOrdine.Location = new Point(457, 829);
            txtDataPrimoOrdine.Name = "txtDataPrimoOrdine";
            txtDataPrimoOrdine.Size = new Size(319, 48);
            txtDataPrimoOrdine.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 742);
            label5.Name = "label5";
            label5.Size = new Size(35, 42);
            label5.TabIndex = 17;
            label5.Text = "€";
            // 
            // ClientiDettaglioForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 1042);
            Controls.Add(label5);
            Controls.Add(txtDataPrimoOrdine);
            Controls.Add(txtImportoTotale);
            Controls.Add(txtOrdiniTotali);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Controls.Add(dtpSubscription);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtPartitaIVA);
            Controls.Add(txtCodiceFiscale);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Font = new Font("Segoe UI", 13F);
            Margin = new Padding(4);
            Name = "ClientiDettaglioForm";
            Text = "Dettagli Cliente";
            ((System.ComponentModel.ISupportInitialize)bindingSourceClientDTO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtCodiceFiscale;
        private TextBox txtPartitaIVA;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private DateTimePicker dtpSubscription;
        private Label label1;
        private Button btnConfirm;
        private Button btnCancel;
        private BindingSource bindingSourceClientDTO;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtOrdiniTotali;
        private TextBox txtImportoTotale;
        private TextBox txtDataPrimoOrdine;
        private Label label5;
    }
}