namespace Car_Showroom
{
    partial class BookList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            idCoulumn = new DataGridViewTextBoxColumn();
            ModelColumn = new DataGridViewTextBoxColumn();
            ColorColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            MobileNoColumn = new DataGridViewTextBoxColumn();
            PayColumn = new DataGridViewTextBoxColumn();
            AmountColumn = new DataGridViewTextBoxColumn();
            TIME = new DataGridViewTextBoxColumn();
            btnDeleteAll = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Charlemagne Std", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(482, 33);
            label2.Name = "label2";
            label2.Size = new Size(283, 52);
            label2.TabIndex = 14;
            label2.Text = "BOOK LIST";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idCoulumn, ModelColumn, ColorColumn, NameColumn, MobileNoColumn, PayColumn, AmountColumn, TIME });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(-1, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1165, 408);
            dataGridView1.TabIndex = 15;
            // 
            // idCoulumn
            // 
            idCoulumn.DataPropertyName = "Id";
            idCoulumn.HeaderText = "ID";
            idCoulumn.MinimumWidth = 8;
            idCoulumn.Name = "idCoulumn";
            idCoulumn.Visible = false;
            idCoulumn.Width = 80;
            // 
            // ModelColumn
            // 
            ModelColumn.DataPropertyName = "Model";
            ModelColumn.HeaderText = "MODEL";
            ModelColumn.MinimumWidth = 8;
            ModelColumn.Name = "ModelColumn";
            ModelColumn.Width = 130;
            // 
            // ColorColumn
            // 
            ColorColumn.DataPropertyName = "Color";
            ColorColumn.HeaderText = "COLOR";
            ColorColumn.MinimumWidth = 8;
            ColorColumn.Name = "ColorColumn";
            ColorColumn.Width = 120;
            // 
            // NameColumn
            // 
            NameColumn.DataPropertyName = "Name";
            NameColumn.HeaderText = "CUSTOMER NAME";
            NameColumn.MinimumWidth = 8;
            NameColumn.Name = "NameColumn";
            NameColumn.Width = 150;
            // 
            // MobileNoColumn
            // 
            MobileNoColumn.DataPropertyName = "MobileNo";
            MobileNoColumn.HeaderText = "MOBILE NO";
            MobileNoColumn.MinimumWidth = 8;
            MobileNoColumn.Name = "MobileNoColumn";
            MobileNoColumn.Width = 150;
            // 
            // PayColumn
            // 
            PayColumn.DataPropertyName = "PaymentMethod";
            PayColumn.HeaderText = "PAYMENT METHOD";
            PayColumn.MinimumWidth = 8;
            PayColumn.Name = "PayColumn";
            PayColumn.Width = 150;
            // 
            // AmountColumn
            // 
            AmountColumn.DataPropertyName = "Amount";
            AmountColumn.HeaderText = "AMOUNT";
            AmountColumn.MinimumWidth = 8;
            AmountColumn.Name = "AmountColumn";
            AmountColumn.Width = 150;
            // 
            // TIME
            // 
            TIME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TIME.DataPropertyName = "Time";
            TIME.HeaderText = "TIME";
            TIME.MinimumWidth = 8;
            TIME.Name = "TIME";
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.Maroon;
            btnDeleteAll.FlatStyle = FlatStyle.Popup;
            btnDeleteAll.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteAll.ForeColor = Color.White;
            btnDeleteAll.Location = new Point(690, 540);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(227, 45);
            btnDeleteAll.TabIndex = 30;
            btnDeleteAll.Text = "DELETE ALL DATA";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Maroon;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(934, 540);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(194, 45);
            btnBack.TabIndex = 31;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // BookList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1160, 607);
            Controls.Add(btnBack);
            Controls.Add(btnDeleteAll);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Name = "BookList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookList";
            Activated += BookList_Activated;
            Load += BookList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private Button btnDeleteAll;
        private Button btnBack;
        private DataGridViewTextBoxColumn idCoulumn;
        private DataGridViewTextBoxColumn ModelColumn;
        private DataGridViewTextBoxColumn ColorColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn MobileNoColumn;
        private DataGridViewTextBoxColumn PayColumn;
        private DataGridViewTextBoxColumn AmountColumn;
        private DataGridViewTextBoxColumn TIME;
    }
}