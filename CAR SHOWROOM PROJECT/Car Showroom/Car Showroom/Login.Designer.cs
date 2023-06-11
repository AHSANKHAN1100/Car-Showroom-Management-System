namespace Car_Showroom
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            btnAdminLogin = new Button();
            txtPassword = new TextBox();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            btnUserLogin = new Button();
            linkLabel2 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Charlemagne Std", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(228, 36);
            label1.Name = "label1";
            label1.Size = new Size(316, 48);
            label1.TabIndex = 0;
            label1.Text = "LOGIN FORM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(87, 137);
            label2.Name = "label2";
            label2.Size = new Size(101, 32);
            label2.TabIndex = 1;
            label2.Text = "EMAIL :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(87, 225);
            label3.Name = "label3";
            label3.Size = new Size(161, 32);
            label3.TabIndex = 2;
            label3.Text = "PASSWORD :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(276, 140);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(370, 41);
            txtEmail.TabIndex = 3;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.BackColor = Color.Teal;
            btnAdminLogin.FlatStyle = FlatStyle.Popup;
            btnAdminLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdminLogin.ForeColor = Color.White;
            btnAdminLogin.Location = new Point(87, 363);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(275, 47);
            btnAdminLogin.TabIndex = 5;
            btnAdminLogin.Text = "ADMIN LOGIN";
            btnAdminLogin.UseVisualStyleBackColor = false;
            btnAdminLogin.Click += btnAdminLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(276, 225);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(370, 41);
            txtPassword.TabIndex = 6;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(430, 296);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(202, 36);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.FromArgb(0, 0, 192);
            linkLabel1.LinkColor = Color.FromArgb(192, 0, 0);
            linkLabel1.Location = new Point(390, 433);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(263, 28);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "ADMIN FORGET PASSWORD";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // btnUserLogin
            // 
            btnUserLogin.BackColor = Color.Teal;
            btnUserLogin.FlatStyle = FlatStyle.Popup;
            btnUserLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUserLogin.ForeColor = Color.White;
            btnUserLogin.Location = new Point(390, 363);
            btnUserLogin.Name = "btnUserLogin";
            btnUserLogin.Size = new Size(256, 47);
            btnUserLogin.TabIndex = 9;
            btnUserLogin.Text = "USER LOGIN";
            btnUserLogin.UseVisualStyleBackColor = false;
            btnUserLogin.Click += btnUserLogin_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.ForeColor = Color.FromArgb(0, 0, 192);
            linkLabel2.LinkColor = Color.FromArgb(192, 0, 0);
            linkLabel2.Location = new Point(87, 433);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(235, 28);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "ONLY FOR USER SIGN UP";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(729, 497);
            Controls.Add(linkLabel2);
            Controls.Add(btnUserLogin);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(txtPassword);
            Controls.Add(btnAdminLogin);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox txtEmail;
        private Button btnAdminLogin;
        public TextBox txtPassword;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Button btnUserLogin;
        private LinkLabel linkLabel2;
    }
}