namespace SportAdoNet.UI
{
    partial class SportForm
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
            listBox1 = new ListBox();
            bindingSourceSport = new BindingSource(components);
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSourceSport).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.DataSource = bindingSourceSport;
            listBox1.DisplayMember = "InfoSport";
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(355, 454);
            listBox1.TabIndex = 0;
            // 
            // bindingSourceSport
            // 
            bindingSourceSport.DataSource = typeof(Models.Sport);
            // 
            // btnNew
            // 
            btnNew.Location = new Point(399, 12);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(187, 57);
            btnNew.TabIndex = 1;
            btnNew.Text = "Nuovo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += Nuovo;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(399, 113);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(187, 57);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Modifica";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += Modifica;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(399, 215);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(187, 57);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Elimina";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += Elimina;
            // 
            // SportForm
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 515);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(listBox1);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5);
            Name = "SportForm";
            Text = "SportForm";
            ((System.ComponentModel.ISupportInitialize)bindingSourceSport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private BindingSource bindingSourceSport;
    }
}