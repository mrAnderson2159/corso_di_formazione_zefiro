namespace SportAdoNet.UI
{
    partial class PersoneForm
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
            bindingSourceSport = new BindingSource(components);
            btnNew = new Button();
            lstPersone = new ListBox();
            bindingSourcePersona = new BindingSource(components);
            label1 = new Label();
            btnUpdate = new Button();
            btnElimina = new Button();
            cmbSportPF = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)bindingSourceSport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePersona).BeginInit();
            SuspendLayout();
            // 
            // bindingSourceSport
            // 
            bindingSourceSport.DataSource = typeof(Models.Sport);
            // 
            // btnNew
            // 
            btnNew.Location = new Point(567, 125);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(187, 57);
            btnNew.TabIndex = 0;
            btnNew.Text = "Nuova";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += Nuovo;
            // 
            // lstPersone
            // 
            lstPersone.DataSource = bindingSourcePersona;
            lstPersone.DisplayMember = "InfoPersona";
            lstPersone.FormattingEnabled = true;
            lstPersone.Location = new Point(23, 125);
            lstPersone.Name = "lstPersone";
            lstPersone.Size = new Size(505, 354);
            lstPersone.TabIndex = 1;
            // 
            // bindingSourcePersona
            // 
            bindingSourcePersona.DataSource = typeof(Models.Persona);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 31);
            label1.Name = "label1";
            label1.Size = new Size(281, 51);
            label1.TabIndex = 2;
            label1.Text = "Cerca per Sport";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(567, 218);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(187, 57);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Modifica";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += Modifica;
            // 
            // cmbSportPF
            // 
            cmbSportPF.DataSource = bindingSourceSport;
            cmbSportPF.DisplayMember = "Nome";
            cmbSportPF.FormattingEnabled = true;
            cmbSportPF.Location = new Point(332, 31);
            cmbSportPF.Name = "cmbSportPF";
            cmbSportPF.Size = new Size(438, 58);
            cmbSportPF.TabIndex = 3;
            cmbSportPF.ValueMember = "Id";
            cmbSportPF.SelectedValueChanged += FiltraListaPersone;
            // 
            // btnElimina
            // 
            btnElimina.Location = new Point(567, 311);
            btnElimina.Name = "btnElimina";
            btnElimina.Size = new Size(187, 57);
            btnElimina.TabIndex = 5;
            btnElimina.Text = "Elimina";
            btnElimina.UseVisualStyleBackColor = true;
            btnElimina.Click += Elimina;
            // 
            // PersoneForm
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 542);
            Controls.Add(btnElimina);
            Controls.Add(btnUpdate);
            Controls.Add(cmbSportPF);
            Controls.Add(label1);
            Controls.Add(lstPersone);
            Controls.Add(btnNew);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(6);
            Name = "PersoneForm";
            Text = "PersoneForm";
            ((System.ComponentModel.ISupportInitialize)bindingSourceSport).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePersona).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNew;
        private ListBox lstPersone;
        private BindingSource bindingSourcePersona;
        private Label label1;
        private ComboBox cmbSportPF;
        private BindingSource bindingSourceSport;
        private Button btnUpdate;
        private Button btnElimina;
    }
}