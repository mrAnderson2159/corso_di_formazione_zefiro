namespace CollectionsForm
{
    partial class TemperatureForm
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
            label1 = new Label();
            txtTemperature = new NumericUpDown();
            btnInsert = new Button();
            lstTemperature = new ListBox();
            btnMin = new Button();
            btnAvg = new Button();
            btnMax = new Button();
            btnReset = new Button();
            lblMin = new Label();
            lblAvg = new Label();
            lblMax = new Label();
            ((System.ComponentModel.ISupportInitialize)txtTemperature).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 28);
            label1.Name = "label1";
            label1.Size = new Size(231, 30);
            label1.TabIndex = 0;
            label1.Text = "Temperature da inserire";
            // 
            // txtTemperature
            // 
            txtTemperature.Location = new Point(295, 26);
            txtTemperature.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(109, 35);
            txtTemperature.TabIndex = 1;
            txtTemperature.KeyDown += txtTemperature_KeyDown;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(488, 23);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(131, 40);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Inserisci";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // lstTemperature
            // 
            lstTemperature.FormattingEnabled = true;
            lstTemperature.Location = new Point(39, 77);
            lstTemperature.Name = "lstTemperature";
            lstTemperature.Size = new Size(365, 334);
            lstTemperature.TabIndex = 3;
            // 
            // btnMin
            // 
            btnMin.Location = new Point(426, 114);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(193, 40);
            btnMin.TabIndex = 4;
            btnMin.Text = "Calcola Minima";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnAvg
            // 
            btnAvg.Location = new Point(426, 190);
            btnAvg.Name = "btnAvg";
            btnAvg.Size = new Size(193, 40);
            btnAvg.TabIndex = 5;
            btnAvg.Text = "Calcola Media";
            btnAvg.UseVisualStyleBackColor = true;
            btnAvg.Click += btnAvg_Click;
            // 
            // btnMax
            // 
            btnMax.Location = new Point(426, 268);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(193, 40);
            btnMax.TabIndex = 6;
            btnMax.Text = "Calcola Massima";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(426, 371);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(193, 40);
            btnReset.TabIndex = 7;
            btnReset.Text = "Svuota Lista";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Location = new Point(656, 119);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(54, 30);
            lblMin.TabIndex = 8;
            lblMin.Text = "MIN";
            // 
            // lblAvg
            // 
            lblAvg.AutoSize = true;
            lblAvg.Location = new Point(656, 195);
            lblAvg.Name = "lblAvg";
            lblAvg.Size = new Size(52, 30);
            lblAvg.TabIndex = 9;
            lblAvg.Text = "AVG";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(656, 273);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(58, 30);
            lblMax.TabIndex = 10;
            lblMax.Text = "MAX";
            // 
            // TemperatureForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 450);
            Controls.Add(lblMax);
            Controls.Add(lblAvg);
            Controls.Add(lblMin);
            Controls.Add(btnReset);
            Controls.Add(btnMax);
            Controls.Add(btnAvg);
            Controls.Add(btnMin);
            Controls.Add(lstTemperature);
            Controls.Add(btnInsert);
            Controls.Add(txtTemperature);
            Controls.Add(label1);
            Name = "TemperatureForm";
            Text = "TemperatureForm";
            ((System.ComponentModel.ISupportInitialize)txtTemperature).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown txtTemperature;
        private Button btnInsert;
        private ListBox lstTemperature;
        private Button btnMin;
        private Button btnAvg;
        private Button btnMax;
        private Button btnReset;
        private Label lblMin;
        private Label lblAvg;
        private Label lblMax;
    }
}