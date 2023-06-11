namespace Car_Showroom
{
    partial class CarModelsList
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            btnBack = new Button();
            idColumn = new DataGridViewTextBoxColumn();
            modelColumn = new DataGridViewTextBoxColumn();
            nameColumn = new DataGridViewTextBoxColumn();
            colorColumn = new DataGridViewTextBoxColumn();
            priceColumn = new DataGridViewTextBoxColumn();
            updateButton = new DataGridViewButtonColumn();
            deleteButton = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Charlemagne Std", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(370, 35);
            label2.Name = "label2";
            label2.Size = new Size(413, 48);
            label2.TabIndex = 1;
            label2.Text = "CAR MODELS LIST";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idColumn, modelColumn, nameColumn, colorColumn, priceColumn, updateButton, deleteButton });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(-2, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1112, 431);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Maroon;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(922, 557);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(142, 36);
            btnBack.TabIndex = 7;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // idColumn
            // 
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "ID";
            idColumn.MinimumWidth = 8;
            idColumn.Name = "idColumn";
            idColumn.Visible = false;
            idColumn.Width = 150;
            // 
            // modelColumn
            // 
            modelColumn.DataPropertyName = "Model";
            modelColumn.HeaderText = "MODEL";
            modelColumn.MinimumWidth = 8;
            modelColumn.Name = "modelColumn";
            modelColumn.Width = 170;
            // 
            // nameColumn
            // 
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "NAME";
            nameColumn.MinimumWidth = 8;
            nameColumn.Name = "nameColumn";
            nameColumn.Width = 170;
            // 
            // colorColumn
            // 
            colorColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colorColumn.DataPropertyName = "Color";
            colorColumn.HeaderText = "COLORS";
            colorColumn.MinimumWidth = 8;
            colorColumn.Name = "colorColumn";
            // 
            // priceColumn
            // 
            priceColumn.DataPropertyName = "Price";
            priceColumn.HeaderText = "PRICE";
            priceColumn.MinimumWidth = 8;
            priceColumn.Name = "priceColumn";
            priceColumn.Width = 150;
            // 
            // updateButton
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Cyan;
            updateButton.DefaultCellStyle = dataGridViewCellStyle2;
            updateButton.HeaderText = "UPDATE";
            updateButton.MinimumWidth = 8;
            updateButton.Name = "updateButton";
            updateButton.Text = "UPDATE";
            updateButton.UseColumnTextForButtonValue = true;
            updateButton.Width = 150;
            // 
            // deleteButton
            // 
            deleteButton.HeaderText = "DELETE";
            deleteButton.MinimumWidth = 8;
            deleteButton.Name = "deleteButton";
            deleteButton.Text = "DELETE";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.Width = 150;
            // 
            // CarModelsList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1106, 615);
            Controls.Add(btnBack);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Name = "CarModelsList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarModelsList";
            Activated += CarModelsList_Activated;
            Load += CarModelsList_Load;
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
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn colorColumn;
        private DataGridViewTextBoxColumn priceColumn;
        private DataGridViewButtonColumn updateButton;
        private DataGridViewButtonColumn deleteButton;
    }
}