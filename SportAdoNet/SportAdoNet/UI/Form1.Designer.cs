namespace SportAdoNet
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
            btnPersone = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnPersone
            // 
            btnPersone.Location = new Point(21, 23);
            btnPersone.Name = "btnPersone";
            btnPersone.Size = new Size(351, 68);
            btnPersone.TabIndex = 0;
            btnPersone.Text = "Gestione Persone";
            btnPersone.UseVisualStyleBackColor = true;
            btnPersone.Click += btnPersone_Click;
            // 
            // button1
            // 
            button1.Location = new Point(22, 132);
            button1.Name = "button1";
            button1.Size = new Size(351, 68);
            button1.TabIndex = 1;
            button1.Text = "Gestione Sport";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 249);
            Controls.Add(button1);
            Controls.Add(btnPersone);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPersone;
        private Button button1;
    }
}
