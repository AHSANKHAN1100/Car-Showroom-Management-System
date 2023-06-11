namespace Car_Showroom
{
    partial class Forget_Password
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
            btnConfirm = new Button();
            txtNewPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtConPassword = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            ckPassword = new CheckBox();
            linkBackLogin = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Teal;
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(32, 259);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(539, 52);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(262, 53);
            txtNewPassword.Multiline = true;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(309, 41);
            txtNewPassword.TabIndex = 1;
            txtNewPassword.UseSystemPasswordChar = true;
            txtNewPassword.Leave += txtNewPassword_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 66);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 2;
            label1.Text = "NEW PASSWORD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 153);
            label2.Name = "label2";
            label2.Size = new Size(224, 28);
            label2.TabIndex = 3;
            label2.Text = "CONFIRM PASSWORD:";
            // 
            // txtConPassword
            // 
            txtConPassword.Location = new Point(262, 140);
            txtConPassword.Multiline = true;
            txtConPassword.Name = "txtConPassword";
            txtConPassword.PasswordChar = '*';
            txtConPassword.Size = new Size(309, 41);
            txtConPassword.TabIndex = 4;
            txtConPassword.UseSystemPasswordChar = true;
            txtConPassword.Leave += txtConPassword_Leave;
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
            // ckPassword
            // 
            ckPassword.AutoSize = true;
            ckPassword.ForeColor = Color.White;
            ckPassword.Location = new Point(409, 208);
            ckPassword.Name = "ckPassword";
            ckPassword.Size = new Size(162, 29);
            ckPassword.TabIndex = 6;
            ckPassword.Text = "Show Password";
            ckPassword.UseVisualStyleBackColor = true;
            ckPassword.CheckedChanged += ckPassword_CheckedChanged;
            // 
            // linkBackLogin
            // 
            linkBackLogin.AutoSize = true;
            linkBackLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkBackLogin.LinkColor = Color.FromArgb(192, 0, 0);
            linkBackLogin.Location = new Point(420, 314);
            linkBackLogin.Name = "linkBackLogin";
            linkBackLogin.Size = new Size(151, 28);
            linkBackLogin.TabIndex = 12;
            linkBackLogin.TabStop = true;
            linkBackLogin.Text = "BACK TO LOGIN";
            linkBackLogin.LinkClicked += linkBackLogin_LinkClicked;
            // 
            // Forget_Password
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(616, 364);
            Controls.Add(linkBackLogin);
            Controls.Add(ckPassword);
            Controls.Add(txtConPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNewPassword);
            Controls.Add(btnConfirm);
            Name = "Forget_Password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forget_Password";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private TextBox txtNewPassword;
        private Label label1;
        private Label label2;
        private TextBox txtConPassword;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private CheckBox ckPassword;
        private LinkLabel linkBackLogin;
    }
}