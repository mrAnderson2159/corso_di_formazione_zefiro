namespace OrdiniAdoNet.UI.Ordini
{
    partial class OrdiniDettaglioForm
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
            bindingSourceOrdiniDTO = new BindingSource(components);
            bindingSourceClientiDTO = new BindingSource(components);
            textBox1 = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            comboBox1 = new ComboBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSourceOrdiniDTO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceClientiDTO).BeginInit();
            SuspendLayout();
            // 
            // bindingSourceOrdiniDTO
            // 
            bindingSourceOrdiniDTO.DataSource = typeof(DTOs.OrdineDTO);
            // 
            // bindingSourceClientiDTO
            // 
            bindingSourceClientiDTO.DataSource = typeof(DTOs.ClienteDTO);
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSourceOrdiniDTO, "Numero", true));
            textBox1.Location = new Point(17, 16);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Numero Ordine...";
            textBox1.Size = new Size(582, 48);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 93);
            label1.Name = "label1";
            label1.Size = new Size(185, 42);
            label1.TabIndex = 1;
            label1.Text = "Data Ordine";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DataBindings.Add(new Binding("Value", bindingSourceOrdiniDTO, "DataOrdine", true));
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(321, 87);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(278, 48);
            dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 171);
            label2.Name = "label2";
            label2.Size = new Size(114, 42);
            label2.TabIndex = 3;
            label2.Text = "Cliente";
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("SelectedValue", bindingSourceOrdiniDTO, "ClienteId", true));
            comboBox1.DataSource = bindingSourceClientiDTO;
            comboBox1.DisplayMember = "InfoCliente";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(321, 168);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(278, 49);
            comboBox1.TabIndex = 4;
            comboBox1.ValueMember = "Id";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(321, 310);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(278, 65);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Salva";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 310);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(278, 65);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Annulla";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // OrdiniDettaglioForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 447);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 13F);
            Margin = new Padding(4);
            Name = "OrdiniDettaglioForm";
            Text = "Dettagli Ordine";
            Load += OrdiniDettaglioForm_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSourceOrdiniDTO).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceClientiDTO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSourceOrdiniDTO;
        private BindingSource bindingSourceClientiDTO;
        private TextBox textBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox comboBox1;
        private Button btnSubmit;
        private Button btnCancel;
    }
}