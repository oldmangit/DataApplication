using DataApplication.Models;
using DataApplication.Repository;
//using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataApplication.GUI_Forms
{
    public partial class ModeSelectionForm : BaseForm
    {
        private readonly IUserRepository _repo;
        public event EventHandler OnlineModeSelected;
        public event EventHandler LogoutRequested;
        public event EventHandler ShutdownApp;

        public User CurrentUser { get; set; }

        public ModeSelectionForm(IUserRepository repo)
        {
            InitializeComponent();
            _repo = repo;
        }
        public void InitializeUser(User user)
        {
            CurrentUser = user;
            ApplyRolePermissions(CurrentUser.Role);

        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ShutdownApp?.Invoke(this, EventArgs.Empty);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to Log out of session?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                LogoutRequested?.Invoke(this, EventArgs.Empty);
            }
            else
                return;
        }

        private void btnOnlineMode_Click(object sender, EventArgs e)
        {
            OnlineModeSelected?.Invoke(this, EventArgs.Empty);
        }

        //public void ShowStudentMode()
        //{
        //    btnOnlineMode.Visible = true;
        //    btnDiagnostics.Visible = false;
        //    btnAdministration.Visible = false;
        //    btnHelp.Visible = true;
        //}
        //public void ShowInstructorMode()
        //{
        //    btnOnlineMode.Visible = true;
        //    btnDiagnostics.Visible = true;
        //    btnAdministration.Visible = false;
        //    btnHelp.Visible = true;
        //}

        //public void ShowAdminMode()
        //{
        //    btnOnlineMode.Visible = true;
        //    btnDiagnostics.Visible = true;
        //    btnAdministration.Visible = true;
        //    btnHelp.Visible = true;
        //}

        public void ApplyRolePermissions(string role)
        {
            switch (role.ToLower())
            {
                case "student":

                    btnOnlineMode.Enabled = true;
                    btnDiagnostics.Enabled = false;
                    btnDiagnostics.ForeColor = Color.LightGray;
                    btnAdministration.Enabled = false;
                    btnHelp.Enabled = true;

                    break;

                case "instructor":

                    btnOnlineMode.Enabled = true;
                    btnDiagnostics.Enabled = true;
                    btnAdministration.Enabled = false;
                    btnHelp.Enabled = true;

                    break;

                case "maintainer":
                    btnOnlineMode.Enabled = true;
                    btnDiagnostics.Enabled = true;
                    btnAdministration.Enabled = false;
                    btnHelp.Enabled = true;
                    break;

                case "admin":

                    btnOnlineMode.Enabled = true;
                    btnDiagnostics.Enabled = true;
                    btnAdministration.Enabled = true;
                    btnHelp.Enabled = true;

                    break;
            }
        }

        private void ModeSelectionForm_Load(object sender, EventArgs e)
        {


        }
    }
}
