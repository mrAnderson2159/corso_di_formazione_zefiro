namespace OrdiniAdoNet.UI.Prodotti
{
    partial class ProdottiForm
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
            txtNameSearch = new TextBox();
            listBox1 = new ListBox();
            bindingSourceProductsDTO = new BindingSource(components);
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSourceProductsDTO).BeginInit();
            SuspendLayout();
            // 
            // txtNameSearch
            // 
            txtNameSearch.Location = new Point(19, 22);
            txtNameSearch.Name = "txtNameSearch";
            txtNameSearch.PlaceholderText = "Cerca Per Nome...";
            txtNameSearch.Size = new Size(927, 48);
            txtNameSearch.TabIndex = 0;
            txtNameSearch.Click += CercaPerNome;
            txtNameSearch.TextChanged += CercaPerNome;
            // 
            // listBox1
            // 
            listBox1.DataSource = bindingSourceProductsDTO;
            listBox1.DisplayMember = "InfoProdotto";
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(19, 106);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(927, 414);
            listBox1.TabIndex = 1;
            // 
            // bindingSourceProductsDTO
            // 
            bindingSourceProductsDTO.DataSource = typeof(DTOs.ProdottoDTO);
            // 
            // btnNew
            // 
            btnNew.Location = new Point(990, 106);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(167, 59);
            btnNew.TabIndex = 2;
            btnNew.Text = "Nuovo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += Nuovo;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(990, 225);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(167, 59);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Modifica";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += Modifica;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(990, 343);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(167, 59);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Elimina";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += Elimina;
            // 
            // ProdottiForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 566);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(listBox1);
            Controls.Add(txtNameSearch);
            Font = new Font("Segoe UI", 13F);
            Margin = new Padding(4);
            Name = "ProdottiForm";
            Text = "Gestione Prodotti";
            ((System.ComponentModel.ISupportInitialize)bindingSourceProductsDTO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNameSearch;
        private ListBox listBox1;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private BindingSource bindingSourceProductsDTO;
    }
}