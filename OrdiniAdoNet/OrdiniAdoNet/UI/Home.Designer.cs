namespace OrdiniAdoNet.UI
{
    partial class Home
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
            label2 = new Label();
            btnClients = new Button();
            btnProducts = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 9);
            label2.Name = "label2";
            label2.Size = new Size(316, 42);
            label2.TabIndex = 1;
            label2.Text = "Lavazza Management";
            // 
            // btnClients
            // 
            btnClients.Location = new Point(117, 96);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(338, 53);
            btnClients.TabIndex = 2;
            btnClients.Text = "Gestione Clienti";
            btnClients.UseVisualStyleBackColor = true;
            btnClients.Click += btnClients_Click;
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(117, 189);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(338, 53);
            btnProducts.TabIndex = 3;
            btnProducts.Text = "Gestione Prodotti";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // button1
            // 
            button1.Location = new Point(117, 286);
            button1.Name = "button1";
            button1.Size = new Size(338, 53);
            button1.TabIndex = 4;
            button1.Text = "Gestione Ordini";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 523);
            Controls.Add(button1);
            Controls.Add(btnProducts);
            Controls.Add(btnClients);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 13F);
            Margin = new Padding(4);
            Name = "Home";
            Text = "Lavazza Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnClients;
        private Button btnProducts;
        private Button button1;
    }
}