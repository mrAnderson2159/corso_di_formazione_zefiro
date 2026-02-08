namespace OrdiniAdoNet.UI.Clienti
{
    partial class ClientiForm
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
            lstClients = new ListBox();
            bindingSourceClientsDTO = new BindingSource(components);
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSourceClientsDTO).BeginInit();
            SuspendLayout();
            // 
            // txtNameSearch
            // 
            txtNameSearch.Location = new Point(19, 22);
            txtNameSearch.Name = "txtNameSearch";
            txtNameSearch.PlaceholderText = "Cerca per Nome...";
            txtNameSearch.Size = new Size(927, 48);
            txtNameSearch.TabIndex = 0;
            txtNameSearch.TextChanged += CercaPerNome;
            // 
            // lstClients
            // 
            lstClients.DataSource = bindingSourceClientsDTO;
            lstClients.DisplayMember = "InfoCliente";
            lstClients.FormattingEnabled = true;
            lstClients.Location = new Point(19, 106);
            lstClients.Name = "lstClients";
            lstClients.Size = new Size(927, 414);
            lstClients.TabIndex = 1;
            // 
            // bindingSourceClientsDTO
            // 
            bindingSourceClientsDTO.DataSource = typeof(DTOs.ClienteDTO);
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
            // ClientiForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 566);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(lstClients);
            Controls.Add(txtNameSearch);
            Font = new Font("Segoe UI", 13F);
            Margin = new Padding(4);
            Name = "ClientiForm";
            Text = "Gestione Clienti";
            ((System.ComponentModel.ISupportInitialize)bindingSourceClientsDTO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNameSearch;
        private ListBox lstClients;
        private BindingSource bindingSourceClientsDTO;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
    }
}