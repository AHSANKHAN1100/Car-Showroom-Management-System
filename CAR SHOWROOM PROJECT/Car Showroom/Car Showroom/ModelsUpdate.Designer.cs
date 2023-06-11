namespace Car_Showroom
{
    partial class ModelsUpdate
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
            txtModel = new TextBox();
            txtColor = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // txtModel
            // 
            txtModel.Location = new Point(198, 39);
            txtModel.Multiline = true;
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(338, 42);
            txtModel.TabIndex = 0;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(198, 196);
            txtColor.Multiline = true;
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(338, 42);
            txtColor.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(198, 119);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(338, 42);
            txtName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(198, 275);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(338, 42);
            txtPrice.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 38);
            label1.Name = "label1";
            label1.Size = new Size(102, 30);
            label1.TabIndex = 3;
            label1.Text = "MODEL :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 118);
            label2.Name = "label2";
            label2.Size = new Size(90, 30);
            label2.TabIndex = 4;
            label2.Text = "NAME :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(44, 275);
            label3.Name = "label3";
            label3.Size = new Size(86, 30);
            label3.TabIndex = 5;
            label3.Text = "PRICE :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(40, 195);
            label4.Name = "label4";
            label4.Size = new Size(109, 30);
            label4.TabIndex = 5;
            label4.Text = "COLORS :";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(40, 354);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(496, 49);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ModelsUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(579, 447);
            Controls.Add(btnUpdate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtColor);
            Controls.Add(txtModel);
            Name = "ModelsUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModelsUpdate";
            Load += ModelsUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtModel;
        private TextBox txtColor;
        private TextBox txtName;
        private TextBox txtPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnUpdate;
    }
}