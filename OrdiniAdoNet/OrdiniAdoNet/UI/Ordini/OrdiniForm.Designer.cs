namespace OrdiniAdoNet.UI.Ordini
{
    partial class OrdiniForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            bindingSourceOrdini = new BindingSource(components);
            dgwOrdini = new DataGridView();
            numeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataOrdineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cognomeClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            indirizzoClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codiceFiscaleClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            partitaIVAClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btnNew = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSourceOrdini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwOrdini).BeginInit();
            SuspendLayout();
            // 
            // bindingSourceOrdini
            // 
            bindingSourceOrdini.DataSource = typeof(DTOs.OrdineDTO);
            // 
            // dgwOrdini
            // 
            dgwOrdini.AutoGenerateColumns = false;
            dgwOrdini.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgwOrdini.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgwOrdini.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwOrdini.Columns.AddRange(new DataGridViewColumn[] { numeroDataGridViewTextBoxColumn, dataOrdineDataGridViewTextBoxColumn, nomeClienteDataGridViewTextBoxColumn, cognomeClienteDataGridViewTextBoxColumn, indirizzoClienteDataGridViewTextBoxColumn, codiceFiscaleClienteDataGridViewTextBoxColumn, partitaIVAClienteDataGridViewTextBoxColumn });
            dgwOrdini.DataSource = bindingSourceOrdini;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgwOrdini.DefaultCellStyle = dataGridViewCellStyle2;
            dgwOrdini.Location = new Point(26, 29);
            dgwOrdini.Margin = new Padding(2);
            dgwOrdini.Name = "dgwOrdini";
            dgwOrdini.RowHeadersWidth = 72;
            dgwOrdini.Size = new Size(1651, 536);
            dgwOrdini.TabIndex = 0;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            numeroDataGridViewTextBoxColumn.MinimumWidth = 9;
            numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            numeroDataGridViewTextBoxColumn.Width = 130;
            // 
            // dataOrdineDataGridViewTextBoxColumn
            // 
            dataOrdineDataGridViewTextBoxColumn.DataPropertyName = "DataOrdine";
            dataOrdineDataGridViewTextBoxColumn.HeaderText = "Data Ordine";
            dataOrdineDataGridViewTextBoxColumn.MinimumWidth = 9;
            dataOrdineDataGridViewTextBoxColumn.Name = "dataOrdineDataGridViewTextBoxColumn";
            dataOrdineDataGridViewTextBoxColumn.Width = 167;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "NomeCliente";
            nomeClienteDataGridViewTextBoxColumn.HeaderText = "Nome Cliente";
            nomeClienteDataGridViewTextBoxColumn.MinimumWidth = 9;
            nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            nomeClienteDataGridViewTextBoxColumn.Width = 181;
            // 
            // cognomeClienteDataGridViewTextBoxColumn
            // 
            cognomeClienteDataGridViewTextBoxColumn.DataPropertyName = "CognomeCliente";
            cognomeClienteDataGridViewTextBoxColumn.HeaderText = "Cognome Cliente";
            cognomeClienteDataGridViewTextBoxColumn.MinimumWidth = 9;
            cognomeClienteDataGridViewTextBoxColumn.Name = "cognomeClienteDataGridViewTextBoxColumn";
            cognomeClienteDataGridViewTextBoxColumn.Width = 214;
            // 
            // indirizzoClienteDataGridViewTextBoxColumn
            // 
            indirizzoClienteDataGridViewTextBoxColumn.DataPropertyName = "IndirizzoCliente";
            indirizzoClienteDataGridViewTextBoxColumn.HeaderText = "Indirizzo Cliente";
            indirizzoClienteDataGridViewTextBoxColumn.MinimumWidth = 9;
            indirizzoClienteDataGridViewTextBoxColumn.Name = "indirizzoClienteDataGridViewTextBoxColumn";
            indirizzoClienteDataGridViewTextBoxColumn.Width = 203;
            // 
            // codiceFiscaleClienteDataGridViewTextBoxColumn
            // 
            codiceFiscaleClienteDataGridViewTextBoxColumn.DataPropertyName = "CodiceFiscaleCliente";
            codiceFiscaleClienteDataGridViewTextBoxColumn.HeaderText = "Codice Fiscale Cliente";
            codiceFiscaleClienteDataGridViewTextBoxColumn.MinimumWidth = 9;
            codiceFiscaleClienteDataGridViewTextBoxColumn.Name = "codiceFiscaleClienteDataGridViewTextBoxColumn";
            codiceFiscaleClienteDataGridViewTextBoxColumn.Width = 254;
            // 
            // partitaIVAClienteDataGridViewTextBoxColumn
            // 
            partitaIVAClienteDataGridViewTextBoxColumn.DataPropertyName = "PartitaIVACliente";
            partitaIVAClienteDataGridViewTextBoxColumn.HeaderText = "Partita IVA Cliente";
            partitaIVAClienteDataGridViewTextBoxColumn.MinimumWidth = 9;
            partitaIVAClienteDataGridViewTextBoxColumn.Name = "partitaIVAClienteDataGridViewTextBoxColumn";
            partitaIVAClienteDataGridViewTextBoxColumn.Width = 221;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(26, 609);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(212, 61);
            btnNew.TabIndex = 1;
            btnNew.Text = "Nuovo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += Nuovo;
            // 
            // button1
            // 
            button1.Location = new Point(301, 609);
            button1.Name = "button1";
            button1.Size = new Size(212, 61);
            button1.TabIndex = 2;
            button1.Text = "Modifica";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Modifica;
            // 
            // OrdiniForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1692, 693);
            Controls.Add(button1);
            Controls.Add(btnNew);
            Controls.Add(dgwOrdini);
            Font = new Font("Segoe UI", 9F);
            Name = "OrdiniForm";
            Text = "Gestione Ordini";
            Load += OrdiniForm_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSourceOrdini).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwOrdini).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSourceOrdini;
        private DataGridView dgwOrdini;
        private DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataOrdineDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cognomeClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn indirizzoClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codiceFiscaleClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn partitaIVAClienteDataGridViewTextBoxColumn;
        private Button btnNew;
        private Button button1;
    }
}