using DataApplication.Models;
using DataApplication.Repository;
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
    public partial class LoginForm : BaseForm
    {
        private  IUserRepository _repo;
        public event Action<User> LoginSuccess;
        public event EventHandler NewUser;

        
        
        public LoginForm(IUserRepository repo)
        {
            InitializeComponent();
            MaximizeBox = false;
            _repo = repo;

            labelUserRole.Visible = false;
            comboBoxRole.Visible = false;
            btnSave.Visible = false;
            btnBack.Visible = false;
        }
       
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            User? loggedUser = await _repo.GetUserAsync(username);
            bool success = await _repo.LoginUserAsync(username, password);

            if (success)
            {
                LoginSuccess?.Invoke(loggedUser);
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            labelTitleName.Text = "Create new account";
            labelUserRole.Visible = true;
            comboBoxRole.Visible = true;

            linkLabel1.Visible = false;

            btnLogin.Visible = false;

            btnSave.Visible = true;
            btnBack.Visible = true;


        }

        private async void btnSave_Click(object? sender, EventArgs e)
        {
            string user_role = comboBoxRole.Text;
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            bool result = await _repo.RegisterUserAsync(username, user_role, password);

            if (result)
            {
                btnBack_Click(null, null);
            }
            else
            {
                MessageBox.Show("Something is wrong!");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            labelTitleName.Text = "Login into account";
            labelUserRole.Visible = false;
            comboBoxRole.Visible = false;
            btnSave.Visible = false;
            btnBack.Visible = false;
            linkLabel1.Visible = true;
            btnSave.Visible = false;
            btnLogin.Visible = true;
        }
    }
}
