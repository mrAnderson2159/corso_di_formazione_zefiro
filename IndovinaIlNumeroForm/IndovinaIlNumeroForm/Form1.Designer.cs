namespace IndovinaIlNumeroForm
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
            lblInsertNum = new Label();
            txtGiocata = new RichTextBox();
            lblGiocata = new Label();
            btnGioca = new Button();
            btnAzzera = new Button();
            btnSettings = new Button();
            lstTentativi = new ListBox();
            SuspendLayout();
            // 
            // lblInsertNum
            // 
            lblInsertNum.AutoSize = true;
            lblInsertNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblInsertNum.Location = new Point(182, 91);
            lblInsertNum.Margin = new Padding(5, 0, 5, 0);
            lblInsertNum.Name = "lblInsertNum";
            lblInsertNum.Size = new Size(587, 57);
            lblInsertNum.TabIndex = 0;
            lblInsertNum.Text = "Inserisci un numero tra a e b";
            // 
            // txtGiocata
            // 
            txtGiocata.Location = new Point(303, 210);
            txtGiocata.Margin = new Padding(5);
            txtGiocata.Name = "txtGiocata";
            txtGiocata.ScrollBars = RichTextBoxScrollBars.None;
            txtGiocata.Size = new Size(362, 81);
            txtGiocata.TabIndex = 2;
            txtGiocata.Text = "";
            txtGiocata.KeyDown += txtGiocata_KeyDown;
            // 
            // lblGiocata
            // 
            lblGiocata.AutoSize = true;
            lblGiocata.Location = new Point(110, 336);
            lblGiocata.Margin = new Padding(5, 0, 5, 0);
            lblGiocata.Name = "lblGiocata";
            lblGiocata.Size = new Size(343, 51);
            lblGiocata.TabIndex = 3;
            lblGiocata.Text = "Commento Vittoria";
            // 
            // btnGioca
            // 
            btnGioca.Location = new Point(647, 612);
            btnGioca.Margin = new Padding(5);
            btnGioca.Name = "btnGioca";
            btnGioca.Size = new Size(218, 67);
            btnGioca.TabIndex = 4;
            btnGioca.Text = "Gioca";
            btnGioca.UseVisualStyleBackColor = true;
            btnGioca.Click += btnGioca_Click;
            // 
            // btnAzzera
            // 
            btnAzzera.Location = new Point(110, 612);
            btnAzzera.Margin = new Padding(5);
            btnAzzera.Name = "btnAzzera";
            btnAzzera.Size = new Size(218, 67);
            btnAzzera.TabIndex = 5;
            btnAzzera.Text = "Azzera";
            btnAzzera.UseVisualStyleBackColor = true;
            btnAzzera.Click += btnAzzera_Click;
            // 
            // btnSettings
            // 
            btnSettings.Font = new Font("Segoe UI", 9F);
            btnSettings.Location = new Point(815, 12);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(146, 40);
            btnSettings.TabIndex = 8;
            btnSettings.Text = "Impostazioni";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += button1_Click;
            // 
            // lstTentativi
            // 
            lstTentativi.Font = new Font("Segoe UI", 12F);
            lstTentativi.FormattingEnabled = true;
            lstTentativi.Location = new Point(110, 424);
            lstTentativi.Name = "lstTentativi";
            lstTentativi.Size = new Size(755, 156);
            lstTentativi.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 743);
            Controls.Add(lstTentativi);
            Controls.Add(btnSettings);
            Controls.Add(btnAzzera);
            Controls.Add(btnGioca);
            Controls.Add(lblGiocata);
            Controls.Add(txtGiocata);
            Controls.Add(lblInsertNum);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInsertNum;
        private RichTextBox txtGiocata;
        private Label lblGiocata;
        private Button btnGioca;
        private Button btnAzzera;
        private Button btnSettings;
        private ListBox lstTentativi;
    }
}
