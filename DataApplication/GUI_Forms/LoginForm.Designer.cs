namespace DataApplication.GUI_Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            btnLogin = new Button();
            txtPassword = new TextBox();
            label1 = new Label();
            txtUserName = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            btnBack = new Button();
            groupBox1 = new GroupBox();
            lblWarningMessage = new Label();
            btnSave = new Button();
            comboBoxRole = new ComboBox();
            labelUserRole = new Label();
            linkLabel1 = new LinkLabel();
            labelTitleName = new Label();
            panel2 = new Panel();
            panelLogin = new Panel();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(0, 192, 0);
            btnLogin.Location = new Point(234, 176);
            btnLogin.Margin = new Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 32);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(166, 130);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(143, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 86);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "username";
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.None;
            txtUserName.Location = new Point(166, 78);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(143, 23);
            txtUserName.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 138);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "password";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 342);
            panel1.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.SlateGray;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Location = new Point(1, 8);
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(33, 28);
            btnBack.TabIndex = 6;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(lblWarningMessage);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBoxRole);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(labelUserRole);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Location = new Point(207, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 251);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // lblWarningMessage
            // 
            lblWarningMessage.AutoSize = true;
            lblWarningMessage.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWarningMessage.ForeColor = Color.Red;
            lblWarningMessage.Location = new Point(59, 224);
            lblWarningMessage.Name = "lblWarningMessage";
            lblWarningMessage.Size = new Size(0, 16);
            lblWarningMessage.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Location = new Point(166, 176);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(65, 32);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.Anchor = AnchorStyles.None;
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "select any role", "student", "instructor", "maintainer", "admin" });
            comboBoxRole.Location = new Point(166, 28);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(144, 23);
            comboBoxRole.TabIndex = 1;
            // 
            // labelUserRole
            // 
            labelUserRole.Anchor = AnchorStyles.None;
            labelUserRole.AutoSize = true;
            labelUserRole.ForeColor = Color.White;
            labelUserRole.Location = new Point(59, 31);
            labelUserRole.Name = "labelUserRole";
            labelUserRole.Size = new Size(56, 15);
            labelUserRole.TabIndex = 6;
            labelUserRole.Text = "User Role";
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.Red;
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(249, 161);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(59, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "new user?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // labelTitleName
            // 
            labelTitleName.Anchor = AnchorStyles.None;
            labelTitleName.AutoSize = true;
            labelTitleName.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitleName.ForeColor = Color.White;
            labelTitleName.Location = new Point(237, 27);
            labelTitleName.Name = "labelTitleName";
            labelTitleName.Size = new Size(293, 45);
            labelTitleName.TabIndex = 0;
            labelTitleName.Text = "Login into account";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Controls.Add(labelTitleName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(778, 100);
            panel2.TabIndex = 4;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(0, 0, 64);
            panelLogin.Controls.Add(panel1);
            panelLogin.Controls.Add(panel2);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(778, 442);
            panelLogin.TabIndex = 1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 442);
            Controls.Add(panelLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelLogin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private TextBox txtPassword;
        private Label label1;
        private TextBox txtUserName;
        private Label label2;
        private Panel panel1;
        private Label labelTitleName;
        private Panel panel2;
        private Panel panelLogin;
        private LinkLabel linkLabel1;
        private ComboBox comboBoxRole;
        private Label labelUserRole;
        private Button btnSave;
        private Button btnBack;
        private GroupBox groupBox1;
        private Label lblWarningMessage;
    }
}