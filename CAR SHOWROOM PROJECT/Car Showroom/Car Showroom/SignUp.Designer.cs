namespace Car_Showroom
{
    partial class SignUp
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
            label1 = new Label();
            lblName = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnUserSignup = new Button();
            ckPassword = new CheckBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            linkBackLogin = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Charlemagne Std", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(222, 37);
            label1.Name = "label1";
            label1.Size = new Size(221, 52);
            label1.TabIndex = 0;
            label1.Text = "SIGN UP";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(55, 138);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 32);
            lblName.TabIndex = 1;
            lblName.Text = "NAME :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(56, 219);
            label3.Name = "label3";
            label3.Size = new Size(101, 32);
            label3.TabIndex = 2;
            label3.Text = "EMAIL :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(55, 298);
            label4.Name = "label4";
            label4.Size = new Size(161, 32);
            label4.TabIndex = 3;
            label4.Text = "PASSWORD :";
            // 
            // txtName
            // 
            txtName.Location = new Point(232, 128);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(372, 42);
            txtName.TabIndex = 6;
            txtName.KeyPress += txtName_KeyPress;
            txtName.Leave += txtName_Leave;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(232, 209);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(372, 42);
            txtEmail.TabIndex = 7;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(232, 288);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(372, 42);
            txtPassword.TabIndex = 8;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnUserSignup
            // 
            btnUserSignup.BackColor = Color.Teal;
            btnUserSignup.FlatStyle = FlatStyle.Popup;
            btnUserSignup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUserSignup.ForeColor = Color.White;
            btnUserSignup.Location = new Point(55, 415);
            btnUserSignup.Name = "btnUserSignup";
            btnUserSignup.Size = new Size(549, 50);
            btnUserSignup.TabIndex = 9;
            btnUserSignup.Text = "USER SIGNUP";
            btnUserSignup.UseVisualStyleBackColor = false;
            btnUserSignup.Click += btnUserSignup_Click;
            // 
            // ckPassword
            // 
            ckPassword.AutoSize = true;
            ckPassword.BackColor = Color.Transparent;
            ckPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ckPassword.ForeColor = Color.White;
            ckPassword.Location = new Point(402, 351);
            ckPassword.Name = "ckPassword";
            ckPassword.Size = new Size(202, 36);
            ckPassword.TabIndex = 10;
            ckPassword.Text = "Show Password";
            ckPassword.UseVisualStyleBackColor = false;
            ckPassword.CheckedChanged += ckPassword_CheckedChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // linkBackLogin
            // 
            linkBackLogin.AutoSize = true;
            linkBackLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkBackLogin.LinkColor = Color.FromArgb(192, 0, 0);
            linkBackLogin.Location = new Point(453, 468);
            linkBackLogin.Name = "linkBackLogin";
            linkBackLogin.Size = new Size(151, 28);
            linkBackLogin.TabIndex = 11;
            linkBackLogin.TabStop = true;
            linkBackLogin.Text = "BACK TO LOGIN";
            linkBackLogin.LinkClicked += linkBackLogin_LinkClicked;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(659, 525);
            Controls.Add(linkBackLogin);
            Controls.Add(ckPassword);
            Controls.Add(btnUserSignup);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp Form";
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnUserSignup;
        private CheckBox ckPassword;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private LinkLabel linkBackLogin;
    }
}