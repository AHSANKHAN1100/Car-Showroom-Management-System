namespace Car_Showroom
{
    partial class QuotationPrice
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
            btnBack = new Button();
            btnSave = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtPrice = new TextBox();
            txtSellPrice = new TextBox();
            txtRegisFee = new TextBox();
            label2 = new Label();
            cmbModels = new ComboBox();
            txtDocuFee = new TextBox();
            label6 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Teal;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(469, 560);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(355, 52);
            btnBack.TabIndex = 22;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(58, 560);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(357, 52);
            btnSave.TabIndex = 21;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(57, 175);
            label5.Name = "label5";
            label5.Size = new Size(173, 32);
            label5.TabIndex = 20;
            label5.Text = "TOTAL PRICE :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(58, 337);
            label4.Name = "label4";
            label4.Size = new Size(148, 32);
            label4.TabIndex = 19;
            label4.Text = "SALES TAX :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(58, 414);
            label3.Name = "label3";
            label3.Size = new Size(244, 32);
            label3.TabIndex = 18;
            label3.Text = "REGISTRATION FEE :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 108);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 17;
            label1.Text = "MODELS :";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(366, 178);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(457, 40);
            txtPrice.TabIndex = 16;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(367, 340);
            txtSellPrice.Multiline = true;
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.ReadOnly = true;
            txtSellPrice.Size = new Size(457, 40);
            txtSellPrice.TabIndex = 15;
            // 
            // txtRegisFee
            // 
            txtRegisFee.Location = new Point(367, 414);
            txtRegisFee.Multiline = true;
            txtRegisFee.Name = "txtRegisFee";
            txtRegisFee.ReadOnly = true;
            txtRegisFee.Size = new Size(457, 40);
            txtRegisFee.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Charlemagne Std", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(272, 33);
            label2.Name = "label2";
            label2.Size = new Size(376, 38);
            label2.TabIndex = 12;
            label2.Text = "QUOTATION PRICES";
            // 
            // cmbModels
            // 
            cmbModels.FormattingEnabled = true;
            cmbModels.Location = new Point(366, 111);
            cmbModels.Name = "cmbModels";
            cmbModels.Size = new Size(457, 33);
            cmbModels.TabIndex = 1;
            cmbModels.SelectedIndexChanged += cmbModels_SelectedIndexChanged;
            // 
            // txtDocuFee
            // 
            txtDocuFee.Location = new Point(367, 484);
            txtDocuFee.Multiline = true;
            txtDocuFee.Name = "txtDocuFee";
            txtDocuFee.ReadOnly = true;
            txtDocuFee.Size = new Size(457, 40);
            txtDocuFee.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(58, 484);
            label6.Name = "label6";
            label6.Size = new Size(282, 32);
            label6.TabIndex = 25;
            label6.Text = "DOCUMENTATION FEE :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Charlemagne Std", 15.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(257, 269);
            label8.Name = "label8";
            label8.Size = new Size(434, 38);
            label8.TabIndex = 28;
            label8.Text = "INCLUDE TAX AND FEES";
            // 
            // QuotationPrice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(891, 638);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txtDocuFee);
            Controls.Add(cmbModels);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(txtSellPrice);
            Controls.Add(txtRegisFee);
            Controls.Add(label2);
            Name = "QuotationPrice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuotationPrice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnSave;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtPrice;
        private TextBox txtSellPrice;
        private TextBox txtRegisFee;
        private Label label2;
        private ComboBox cmbModels;
        private TextBox txtDocuFee;
        private Label label6;
        private Label label8;
    }
}