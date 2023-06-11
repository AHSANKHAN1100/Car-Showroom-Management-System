namespace Car_Showroom
{
    partial class CarModels
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
            label2 = new Label();
            txtModelName = new TextBox();
            txtCarName = new TextBox();
            txtColors = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSave = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Charlemagne Std", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(221, 46);
            label2.Name = "label2";
            label2.Size = new Size(372, 57);
            label2.TabIndex = 1;
            label2.Text = "CAR MODELS";
            // 
            // txtModelName
            // 
            txtModelName.Location = new Point(317, 136);
            txtModelName.Multiline = true;
            txtModelName.Name = "txtModelName";
            txtModelName.Size = new Size(447, 41);
            txtModelName.TabIndex = 2;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(317, 211);
            txtCarName.Multiline = true;
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(447, 41);
            txtCarName.TabIndex = 3;
            // 
            // txtColors
            // 
            txtColors.Location = new Point(314, 286);
            txtColors.Multiline = true;
            txtColors.Name = "txtColors";
            txtColors.Size = new Size(447, 41);
            txtColors.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(314, 361);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(447, 41);
            txtPrice.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(66, 133);
            label1.Name = "label1";
            label1.Size = new Size(191, 32);
            label1.TabIndex = 6;
            label1.Text = "MODEL NAME :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(66, 208);
            label3.Name = "label3";
            label3.Size = new Size(155, 32);
            label3.TabIndex = 7;
            label3.Text = "CAR NAME :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(66, 283);
            label4.Name = "label4";
            label4.Size = new Size(119, 32);
            label4.TabIndex = 8;
            label4.Text = "COLORS :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(66, 358);
            label5.Name = "label5";
            label5.Size = new Size(95, 32);
            label5.TabIndex = 9;
            label5.Text = "PRICE :";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(66, 446);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(331, 52);
            btnSave.TabIndex = 10;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Teal;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(441, 446);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(321, 52);
            btnBack.TabIndex = 11;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // CarModels
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(815, 546);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(txtColors);
            Controls.Add(txtCarName);
            Controls.Add(txtModelName);
            Controls.Add(label2);
            Name = "CarModels";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarModels";
            Load += CarModels_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtModelName;
        private TextBox txtCarName;
        private TextBox txtColors;
        private TextBox txtPrice;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSave;
        private Button btnBack;
    }
}