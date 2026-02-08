namespace SportAdoNet.UI
{
    partial class SportDettaglioForm
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
            textBox1 = new TextBox();
            bindingSourceSport = new BindingSource(components);
            textBox2 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            bindingSourceComboBox = new BindingSource(components);
            btnConfirm = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSourceSport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceComboBox).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSourceSport, "Nome", true));
            textBox1.Location = new Point(46, 31);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nome...";
            textBox1.Size = new Size(506, 57);
            textBox1.TabIndex = 0;
            // 
            // bindingSourceSport
            // 
            bindingSourceSport.DataSource = typeof(Models.Sport);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSourceSport, "Note", true));
            textBox2.Location = new Point(46, 139);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Note...";
            textBox2.Size = new Size(506, 57);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(46, 258);
            label1.Name = "label1";
            label1.Size = new Size(263, 45);
            label1.TabIndex = 2;
            label1.Text = "Sport di Squadra";
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("SelectedValue", bindingSourceSport, "IsSportSquadra", true));
            comboBox1.DataSource = bindingSourceComboBox;
            comboBox1.DisplayMember = "Nome";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(346, 251);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 58);
            comboBox1.TabIndex = 3;
            comboBox1.ValueMember = "Value";
            // 
            // bindingSourceComboBox
            // 
            bindingSourceComboBox.DataSource = typeof(DTOs.ComboBoxOption);
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(346, 419);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(206, 75);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Salva";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(46, 419);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(206, 75);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Annulla";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // SportDettaglioForm
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 574);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5);
            Name = "SportDettaglioForm";
            Text = "SportDettaglioForm";
            ((System.ComponentModel.ISupportInitialize)bindingSourceSport).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceComboBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private ComboBox comboBox1;
        private BindingSource bindingSourceSport;
        private Button btnConfirm;
        private Button btnCancel;
        private BindingSource bindingSourceComboBox;
    }
}