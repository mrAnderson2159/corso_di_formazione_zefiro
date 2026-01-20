namespace IndovinaIlNumeroForm
{
    partial class Form2
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
            lblSettings = new Label();
            lblMin = new Label();
            Massimo = new Label();
            txtMinimo = new NumericUpDown();
            txtMassimo = new NumericUpDown();
            btnConfirm = new Button();
            btnCancel = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)txtMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMassimo).BeginInit();
            SuspendLayout();
            // 
            // lblSettings
            // 
            lblSettings.AutoSize = true;
            lblSettings.Location = new Point(143, 44);
            lblSettings.Name = "lblSettings";
            lblSettings.Size = new Size(132, 30);
            lblSettings.TabIndex = 0;
            lblSettings.Text = "Impostazioni";
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(40, 121);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(84, 30);
            lblMin.TabIndex = 1;
            lblMin.Text = "Minimo";
            // 
            // Massimo
            // 
            Massimo.AutoSize = true;
            Massimo.Location = new Point(40, 194);
            Massimo.Name = "Massimo";
            Massimo.Size = new Size(96, 30);
            Massimo.TabIndex = 2;
            Massimo.Text = "Massimo";
            // 
            // txtMinimo
            // 
            txtMinimo.Location = new Point(265, 116);
            txtMinimo.Maximum = new decimal(new int[] { -6, 0, 0, 0 });
            txtMinimo.Name = "txtMinimo";
            txtMinimo.Size = new Size(107, 35);
            txtMinimo.TabIndex = 3;
            txtMinimo.ValueChanged += txtMinimo_ValueChanged;
            // 
            // txtMassimo
            // 
            txtMassimo.Location = new Point(265, 189);
            txtMassimo.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            txtMassimo.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            txtMassimo.Name = "txtMassimo";
            txtMassimo.Size = new Size(107, 35);
            txtMassimo.TabIndex = 4;
            txtMassimo.Value = new decimal(new int[] { 2, 0, 0, 0 });
            txtMassimo.ValueChanged += txtMassimo_ValueChanged;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(265, 321);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(107, 40);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Conferma";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(40, 321);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 40);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Annulla";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 6F);
            label1.Location = new Point(40, 380);
            label1.Name = "label1";
            label1.Size = new Size(321, 19);
            label1.TabIndex = 7;
            label1.Text = "Le modifiche verranno applicate al prossimo riavvio";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 408);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(txtMassimo);
            Controls.Add(txtMinimo);
            Controls.Add(Massimo);
            Controls.Add(lblMin);
            Controls.Add(lblSettings);
            HelpButton = true;
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)txtMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMassimo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSettings;
        private Label lblMin;
        internal Label Massimo;
        private NumericUpDown txtMinimo;
        private NumericUpDown txtMassimo;
        private Button btnConfirm;
        private Button btnCancel;
        private Label label1;
    }
}