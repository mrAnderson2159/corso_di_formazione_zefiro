namespace SportAdoNet.UI
{
    partial class PersonaDettaglioForm
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
            bindingSourcePersona = new BindingSource(components);
            txtCognome = new TextBox();
            txtCodiceFiscale = new TextBox();
            txtContatto = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            btnSalva = new Button();
            btnAnnulla = new Button();
            cmbSportPDF = new ComboBox();
            bindingSourceSport = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSourcePersona).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceSport).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.DataBindings.Add(new Binding("Text", bindingSourcePersona, "Nome", true));
            txtNome.Location = new Point(17, 29);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(543, 57);
            txtNome.TabIndex = 0;
            // 
            // bindingSourcePersona
            // 
            bindingSourcePersona.DataSource = typeof(Models.Persona);
            // 
            // txtCognome
            // 
            txtCognome.DataBindings.Add(new Binding("Text", bindingSourcePersona, "Cognome", true));
            txtCognome.Location = new Point(17, 100);
            txtCognome.Name = "txtCognome";
            txtCognome.PlaceholderText = "Cognome";
            txtCognome.Size = new Size(543, 57);
            txtCognome.TabIndex = 1;
            // 
            // txtCodiceFiscale
            // 
            txtCodiceFiscale.DataBindings.Add(new Binding("Text", bindingSourcePersona, "CodiceFiscale", true));
            txtCodiceFiscale.Location = new Point(17, 181);
            txtCodiceFiscale.Name = "txtCodiceFiscale";
            txtCodiceFiscale.PlaceholderText = "Codice Fiscale";
            txtCodiceFiscale.Size = new Size(543, 57);
            txtCodiceFiscale.TabIndex = 2;
            // 
            // txtContatto
            // 
            txtContatto.DataBindings.Add(new Binding("Text", bindingSourcePersona, "InfoContatto", true));
            txtContatto.Location = new Point(17, 260);
            txtContatto.Name = "txtContatto";
            txtContatto.PlaceholderText = "Telefono / Email";
            txtContatto.Size = new Size(543, 57);
            txtContatto.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DataBindings.Add(new Binding("Value", bindingSourcePersona, "DataNascita", true));
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(315, 422);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 57);
            dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 427);
            label1.Name = "label1";
            label1.Size = new Size(273, 51);
            label1.TabIndex = 5;
            label1.Text = "Data di Nascita";
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(381, 510);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(179, 59);
            btnSalva.TabIndex = 6;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // btnAnnulla
            // 
            btnAnnulla.Location = new Point(12, 510);
            btnAnnulla.Name = "btnAnnulla";
            btnAnnulla.Size = new Size(179, 59);
            btnAnnulla.TabIndex = 7;
            btnAnnulla.Text = "Annulla";
            btnAnnulla.UseVisualStyleBackColor = true;
            btnAnnulla.Click += btnAnnulla_Click;
            // 
            // cmbSportPDF
            // 
            cmbSportPDF.DataBindings.Add(new Binding("SelectedValue", bindingSourcePersona, "IdSport", true));
            cmbSportPDF.DataSource = bindingSourceSport;
            cmbSportPDF.DisplayMember = "Nome";
            cmbSportPDF.FormattingEnabled = true;
            cmbSportPDF.Location = new Point(17, 341);
            cmbSportPDF.Name = "cmbSportPDF";
            cmbSportPDF.Size = new Size(543, 58);
            cmbSportPDF.TabIndex = 8;
            cmbSportPDF.ValueMember = "Id";
            // 
            // bindingSourceSport
            // 
            bindingSourceSport.DataSource = typeof(Models.Sport);
            // 
            // PersonaDettaglioForm
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 596);
            Controls.Add(cmbSportPDF);
            Controls.Add(btnAnnulla);
            Controls.Add(btnSalva);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtContatto);
            Controls.Add(txtCodiceFiscale);
            Controls.Add(txtCognome);
            Controls.Add(txtNome);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(6);
            Name = "PersonaDettaglioForm";
            Text = "Persona Dettaglio";
            ((System.ComponentModel.ISupportInitialize)bindingSourcePersona).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceSport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCognome;
        private TextBox txtCodiceFiscale;
        private TextBox txtContatto;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button btnSalva;
        private Button btnAnnulla;
        private BindingSource bindingSourcePersona;
        private ComboBox cmbSportPDF;
        private BindingSource bindingSourceSport;
    }
}