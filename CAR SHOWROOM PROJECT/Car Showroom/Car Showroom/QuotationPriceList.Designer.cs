namespace Car_Showroom
{
    partial class QuotationPriceList
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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            idColumn = new DataGridViewTextBoxColumn();
            modelColumn = new DataGridViewTextBoxColumn();
            priceColumn = new DataGridViewTextBoxColumn();
            selltaxColumn = new DataGridViewTextBoxColumn();
            regisfeeColumn = new DataGridViewTextBoxColumn();
            docufeeColumn = new DataGridViewTextBoxColumn();
            deleteButton = new DataGridViewButtonColumn();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Charlemagne Std", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(267, 31);
            label2.Name = "label2";
            label2.Size = new Size(573, 48);
            label2.TabIndex = 2;
            label2.Text = "QUOTATION PRICES LIST";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idColumn, modelColumn, priceColumn, selltaxColumn, regisfeeColumn, docufeeColumn, deleteButton });
            dataGridView1.Location = new Point(-1, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1097, 429);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // idColumn
            // 
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "ID";
            idColumn.MinimumWidth = 8;
            idColumn.Name = "idColumn";
            idColumn.Visible = false;
            idColumn.Width = 80;
            // 
            // modelColumn
            // 
            modelColumn.DataPropertyName = "Model";
            modelColumn.HeaderText = "MODEL";
            modelColumn.MinimumWidth = 8;
            modelColumn.Name = "modelColumn";
            modelColumn.Width = 140;
            // 
            // priceColumn
            // 
            priceColumn.DataPropertyName = "Price";
            priceColumn.HeaderText = "PRICE";
            priceColumn.MinimumWidth = 8;
            priceColumn.Name = "priceColumn";
            priceColumn.Width = 150;
            // 
            // selltaxColumn
            // 
            selltaxColumn.DataPropertyName = "SellTax";
            selltaxColumn.HeaderText = "SELL TAX";
            selltaxColumn.MinimumWidth = 8;
            selltaxColumn.Name = "selltaxColumn";
            selltaxColumn.Width = 140;
            // 
            // regisfeeColumn
            // 
            regisfeeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            regisfeeColumn.DataPropertyName = "RegistrationFee";
            regisfeeColumn.HeaderText = "REGISTRATION FEE";
            regisfeeColumn.MinimumWidth = 8;
            regisfeeColumn.Name = "regisfeeColumn";
            // 
            // docufeeColumn
            // 
            docufeeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            docufeeColumn.DataPropertyName = "DocumentationFee";
            docufeeColumn.HeaderText = "DOCUMENTATION FEE";
            docufeeColumn.MinimumWidth = 8;
            docufeeColumn.Name = "docufeeColumn";
            // 
            // deleteButton
            // 
            deleteButton.HeaderText = "DELETE";
            deleteButton.MinimumWidth = 8;
            deleteButton.Name = "deleteButton";
            deleteButton.Text = "DELETE";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Width = 140;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Maroon;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(928, 556);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(142, 36);
            btnBack.TabIndex = 7;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // QuotationPriceList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1093, 614);
            Controls.Add(btnBack);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Name = "QuotationPriceList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuotationPriceList";
            Activated += QuotationPriceList_Activated;
            Load += QuotationPriceList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridView1;
        private Button btnBack;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn modelColumn;
        private DataGridViewTextBoxColumn priceColumn;
        private DataGridViewTextBoxColumn selltaxColumn;
        private DataGridViewTextBoxColumn regisfeeColumn;
        private DataGridViewTextBoxColumn docufeeColumn;
        private DataGridViewButtonColumn deleteButton;
    }
}