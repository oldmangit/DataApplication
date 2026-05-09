namespace DataApplication.GUI_Forms
{
    partial class ModeSelectionForm
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
            panel1 = new Panel();
            panel4 = new Panel();
            btnHelp = new Button();
            btnAdministration = new Button();
            btnDiagnostics = new Button();
            btnOnlineMode = new Button();
            panel3 = new Panel();
            btnLogout = new Button();
            btnChangePassword = new Button();
            btnShutdown = new Button();
            panel2 = new Panel();
            labelModeTitle = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ScrollBar;
            panel4.Controls.Add(btnHelp);
            panel4.Controls.Add(btnAdministration);
            panel4.Controls.Add(btnDiagnostics);
            panel4.Controls.Add(btnOnlineMode);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            panel4.Location = new Point(0, 83);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 301);
            panel4.TabIndex = 0;
            // 
            // btnHelp
            // 
            btnHelp.Anchor = AnchorStyles.None;
            btnHelp.BackColor = Color.LightGray;
            btnHelp.Cursor = Cursors.Hand;
            btnHelp.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnHelp.Location = new Point(298, 199);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(205, 45);
            btnHelp.TabIndex = 3;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnAdministration
            // 
            btnAdministration.Anchor = AnchorStyles.None;
            btnAdministration.BackColor = Color.LightGray;
            btnAdministration.Cursor = Cursors.Hand;
            btnAdministration.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnAdministration.Location = new Point(298, 148);
            btnAdministration.Name = "btnAdministration";
            btnAdministration.Size = new Size(205, 45);
            btnAdministration.TabIndex = 2;
            btnAdministration.Text = "Administration Mode";
            btnAdministration.UseVisualStyleBackColor = false;
            // 
            // btnDiagnostics
            // 
            btnDiagnostics.Anchor = AnchorStyles.None;
            btnDiagnostics.BackColor = Color.LightGray;
            btnDiagnostics.Cursor = Cursors.Hand;
            btnDiagnostics.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDiagnostics.Location = new Point(298, 97);
            btnDiagnostics.Name = "btnDiagnostics";
            btnDiagnostics.Size = new Size(205, 45);
            btnDiagnostics.TabIndex = 1;
            btnDiagnostics.Text = "Diagnostics Mode";
            btnDiagnostics.UseVisualStyleBackColor = false;
            // 
            // btnOnlineMode
            // 
            btnOnlineMode.Anchor = AnchorStyles.None;
            btnOnlineMode.BackColor = Color.LightGray;
            btnOnlineMode.Cursor = Cursors.Hand;
            btnOnlineMode.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnOnlineMode.Location = new Point(298, 46);
            btnOnlineMode.Name = "btnOnlineMode";
            btnOnlineMode.Size = new Size(205, 45);
            btnOnlineMode.TabIndex = 0;
            btnOnlineMode.Text = "On-line Mode";
            btnOnlineMode.UseVisualStyleBackColor = false;
            btnOnlineMode.Click += btnOnlineMode_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ScrollBar;
            panel3.Controls.Add(btnLogout);
            panel3.Controls.Add(btnChangePassword);
            panel3.Controls.Add(btnShutdown);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 384);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 66);
            panel3.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.None;
            btnLogout.BackColor = Color.LightGray;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnLogout.Location = new Point(150, 17);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(127, 30);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Log-out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Anchor = AnchorStyles.None;
            btnChangePassword.BackColor = Color.LightGray;
            btnChangePassword.Cursor = Cursors.Hand;
            btnChangePassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnChangePassword.Location = new Point(343, 17);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(127, 30);
            btnChangePassword.TabIndex = 5;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // btnShutdown
            // 
            btnShutdown.Anchor = AnchorStyles.None;
            btnShutdown.BackColor = Color.LightGray;
            btnShutdown.Cursor = Cursors.Hand;
            btnShutdown.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnShutdown.Location = new Point(531, 17);
            btnShutdown.Name = "btnShutdown";
            btnShutdown.Size = new Size(127, 30);
            btnShutdown.TabIndex = 6;
            btnShutdown.Text = "Shutdown";
            btnShutdown.UseVisualStyleBackColor = false;
            btnShutdown.Click += btnShutdown_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(labelModeTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 83);
            panel2.TabIndex = 0;
            // 
            // labelModeTitle
            // 
            labelModeTitle.Anchor = AnchorStyles.None;
            labelModeTitle.AutoSize = true;
            labelModeTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelModeTitle.Location = new Point(230, 19);
            labelModeTitle.Name = "labelModeTitle";
            labelModeTitle.Size = new Size(331, 50);
            labelModeTitle.TabIndex = 0;
            labelModeTitle.Text = "Hawk Mk 132 IOS";
            // 
            // ModeSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModeSelectionForm";
            Text = "ModeSelectionForm";
            Load += ModeSelectionForm_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Button btnHelp;
        private Button btnAdministration;
        private Button btnDiagnostics;
        private Button btnOnlineMode;
        private Panel panel3;
        private Panel panel2;
        private Label labelModeTitle;
        private Button btnLogout;
        private Button btnChangePassword;
        private Button btnShutdown;
    }
}