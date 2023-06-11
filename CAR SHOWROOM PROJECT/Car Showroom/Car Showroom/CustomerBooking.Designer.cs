namespace Car_Showroom
{
    partial class CustomerBooking
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtCustomerName = new TextBox();
            txtAvColors = new TextBox();
            txtAmount = new TextBox();
            txtColor = new TextBox();
            txtMobileNo = new TextBox();
            txtPayMethod = new TextBox();
            cmbAvModels = new ComboBox();
            btnSubmit = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Charlemagne Std", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(283, 39);
            label2.Name = "label2";
            label2.Size = new Size(559, 52);
            label2.TabIndex = 13;
            label2.Text = "CUSTOMER BOOKING";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 150);
            label1.Name = "label1";
            label1.Size = new Size(214, 30);
            label1.TabIndex = 14;
            label1.Text = "CUSTOMER NAME :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 240);
            label3.Name = "label3";
            label3.Size = new Size(233, 30);
            label3.TabIndex = 15;
            label3.Text = "AVAILABLE MODELS :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(28, 321);
            label4.Name = "label4";
            label4.Size = new Size(210, 30);
            label4.TabIndex = 16;
            label4.Text = "AVAILIBIE COLORS:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(571, 160);
            label5.Name = "label5";
            label5.Size = new Size(97, 30);
            label5.TabIndex = 17;
            label5.Text = "COLOR :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(571, 242);
            label6.Name = "label6";
            label6.Size = new Size(147, 30);
            label6.TabIndex = 18;
            label6.Text = "MOBILE NO :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(560, 321);
            label7.Name = "label7";
            label7.Size = new Size(229, 30);
            label7.TabIndex = 19;
            label7.Text = "PAYMENT METHOD :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(28, 394);
            label8.Name = "label8";
            label8.Size = new Size(124, 30);
            label8.TabIndex = 20;
            label8.Text = "AMOUNT :";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(283, 150);
            txtCustomerName.Multiline = true;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(250, 40);
            txtCustomerName.TabIndex = 21;
            // 
            // txtAvColors
            // 
            txtAvColors.Location = new Point(283, 311);
            txtAvColors.Multiline = true;
            txtAvColors.Name = "txtAvColors";
            txtAvColors.Size = new Size(250, 40);
            txtAvColors.TabIndex = 22;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(283, 394);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(250, 40);
            txtAmount.TabIndex = 23;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(795, 150);
            txtColor.Multiline = true;
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(266, 40);
            txtColor.TabIndex = 24;
            // 
            // txtMobileNo
            // 
            txtMobileNo.Location = new Point(795, 232);
            txtMobileNo.Multiline = true;
            txtMobileNo.Name = "txtMobileNo";
            txtMobileNo.Size = new Size(266, 40);
            txtMobileNo.TabIndex = 25;
            // 
            // txtPayMethod
            // 
            txtPayMethod.Location = new Point(795, 311);
            txtPayMethod.Multiline = true;
            txtPayMethod.Name = "txtPayMethod";
            txtPayMethod.Size = new Size(266, 40);
            txtPayMethod.TabIndex = 26;
            // 
            // cmbAvModels
            // 
            cmbAvModels.FormattingEnabled = true;
            cmbAvModels.Location = new Point(283, 241);
            cmbAvModels.Name = "cmbAvModels";
            cmbAvModels.Size = new Size(250, 33);
            cmbAvModels.TabIndex = 27;
            cmbAvModels.SelectedIndexChanged += cmbAvModels_SelectedIndexChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Teal;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(462, 483);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(278, 63);
            btnSubmit.TabIndex = 28;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Maroon;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(787, 483);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(274, 63);
            btnBack.TabIndex = 29;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // CustomerBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1087, 595);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(cmbAvModels);
            Controls.Add(txtPayMethod);
            Controls.Add(txtMobileNo);
            Controls.Add(txtColor);
            Controls.Add(txtAmount);
            Controls.Add(txtAvColors);
            Controls.Add(txtCustomerName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "CustomerBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserHome";
            Load += CustomerBooking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtCustomerName;
        public TextBox txtAvColors;
        private TextBox txtAmount;
        private TextBox txtColor;
        private TextBox txtMobileNo;
        private TextBox txtPayMethod;
        public ComboBox cmbAvModels;
        private Button btnSubmit;
        private Button btnBack;
    }
}