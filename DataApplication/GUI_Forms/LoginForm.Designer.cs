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
            btnSave = new Button();
            comboBoxRole = new ComboBox();
            labelUserRole = new Label();
            linkLabel1 = new LinkLabel();
            labelTitleName = new Label();
            panel2 = new Panel();
            btnBack = new Button();
            panelLogin = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 192, 0);
            btnLogin.Location = new Point(412, 183);
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
            txtPassword.Location = new Point(344, 137);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(143, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(237, 93);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "username";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(344, 85);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(143, 23);
            txtUserName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(237, 145);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "password";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(comboBoxRole);
            panel1.Controls.Add(labelUserRole);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 342);
            panel1.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(344, 183);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(65, 32);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "student", "instructor", "maintainer", "admin" });
            comboBoxRole.Location = new Point(344, 35);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(144, 23);
            comboBoxRole.TabIndex = 7;
            // 
            // labelUserRole
            // 
            labelUserRole.AutoSize = true;
            labelUserRole.ForeColor = Color.White;
            labelUserRole.Location = new Point(237, 38);
            labelUserRole.Name = "labelUserRole";
            labelUserRole.Size = new Size(56, 15);
            labelUserRole.TabIndex = 6;
            labelUserRole.Text = "User Role";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.Red;
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(427, 168);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(59, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "new user?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // labelTitleName
            // 
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
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(labelTitleName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(778, 100);
            panel2.TabIndex = 4;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SlateGray;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(33, 28);
            btnBack.TabIndex = 6;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}