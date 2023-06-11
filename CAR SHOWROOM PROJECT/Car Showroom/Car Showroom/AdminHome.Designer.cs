namespace Car_Showroom
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            label1 = new Label();
            btnCarModels = new Button();
            btnQuotationPrices = new Button();
            btnBookList = new Button();
            linkCarModelList = new LinkLabel();
            linkPricesList = new LinkLabel();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Charlemagne Std", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(319, 39);
            label1.Name = "label1";
            label1.Size = new Size(416, 57);
            label1.TabIndex = 0;
            label1.Text = "ADMIN HOME ";
            // 
            // btnCarModels
            // 
            btnCarModels.BackColor = Color.Teal;
            btnCarModels.FlatStyle = FlatStyle.Popup;
            btnCarModels.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarModels.ForeColor = Color.White;
            btnCarModels.Location = new Point(58, 579);
            btnCarModels.Name = "btnCarModels";
            btnCarModels.Size = new Size(295, 72);
            btnCarModels.TabIndex = 1;
            btnCarModels.Text = "CAR MODELS";
            btnCarModels.UseVisualStyleBackColor = false;
            btnCarModels.Click += btnCarModels_Click;
            // 
            // btnQuotationPrices
            // 
            btnQuotationPrices.BackColor = Color.Teal;
            btnQuotationPrices.FlatStyle = FlatStyle.Popup;
            btnQuotationPrices.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuotationPrices.ForeColor = Color.White;
            btnQuotationPrices.Location = new Point(359, 579);
            btnQuotationPrices.Name = "btnQuotationPrices";
            btnQuotationPrices.Size = new Size(295, 72);
            btnQuotationPrices.TabIndex = 2;
            btnQuotationPrices.Text = "QUOTATION PRICE";
            btnQuotationPrices.UseVisualStyleBackColor = false;
            btnQuotationPrices.Click += btnQuotationPrices_Click;
            // 
            // btnBookList
            // 
            btnBookList.BackColor = Color.Teal;
            btnBookList.FlatStyle = FlatStyle.Popup;
            btnBookList.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBookList.ForeColor = Color.White;
            btnBookList.Location = new Point(660, 579);
            btnBookList.Name = "btnBookList";
            btnBookList.Size = new Size(295, 72);
            btnBookList.TabIndex = 3;
            btnBookList.Text = "BOOKLIST";
            btnBookList.UseVisualStyleBackColor = false;
            btnBookList.Click += btnBookList_Click;
            // 
            // linkCarModelList
            // 
            linkCarModelList.ActiveLinkColor = Color.White;
            linkCarModelList.AutoSize = true;
            linkCarModelList.BackColor = Color.Transparent;
            linkCarModelList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkCarModelList.LinkColor = Color.White;
            linkCarModelList.Location = new Point(100, 667);
            linkCarModelList.Name = "linkCarModelList";
            linkCarModelList.Size = new Size(208, 32);
            linkCarModelList.TabIndex = 4;
            linkCarModelList.TabStop = true;
            linkCarModelList.Text = "CAR MODELS LIST";
            linkCarModelList.LinkClicked += linkCarModelList_LinkClicked;
            // 
            // linkPricesList
            // 
            linkPricesList.ActiveLinkColor = Color.White;
            linkPricesList.AutoSize = true;
            linkPricesList.BackColor = Color.Transparent;
            linkPricesList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkPricesList.LinkColor = Color.White;
            linkPricesList.Location = new Point(431, 667);
            linkPricesList.Name = "linkPricesList";
            linkPricesList.Size = new Size(137, 32);
            linkPricesList.TabIndex = 5;
            linkPricesList.TabStop = true;
            linkPricesList.Text = "PRICES LIST";
            linkPricesList.LinkClicked += linkPricesList_LinkClicked;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Maroon;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(753, 663);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(142, 36);
            btnBack.TabIndex = 6;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1018, 718);
            Controls.Add(btnBack);
            Controls.Add(linkPricesList);
            Controls.Add(linkCarModelList);
            Controls.Add(btnBookList);
            Controls.Add(btnQuotationPrices);
            Controls.Add(btnCarModels);
            Controls.Add(label1);
            Name = "AdminHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCarModels;
        private Button btnQuotationPrices;
        private Button btnBookList;
        private LinkLabel linkCarModelList;
        private LinkLabel linkPricesList;
        private Button btnBack;
    }
}