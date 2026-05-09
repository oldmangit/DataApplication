using DataApplication.GUI_Forms;
using DataApplication.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication
{
    public class AppControl : ApplicationContext
    {
        private readonly IServiceProvider _provider;

        private LoginForm login;
        private ModeSelectionForm modeForm;

        public User CurrentUser { get; set; }

        public AppControl(IServiceProvider provider)
        {
            _provider = provider;
            ShowLogin();
        }
        
        private void ShowLogin()
        {
            login = _provider.GetRequiredService<LoginForm>();

            login.LoginSuccess += OnLoginSuccess;
            login.FormClosed += OnFormClosed;
            
            login.Show();
        }
       
        private void OnLoginSuccess(User user)
        {
            CurrentUser = user;
            modeForm = _provider.GetRequiredService<ModeSelectionForm>();
            modeForm.InitializeUser(CurrentUser);

            modeForm.FormClosed += OnFormClosed;
            modeForm.LogoutRequested += OnLogoutRequested;
            modeForm.OnlineModeSelected += OnOnlineModeSelected;
            modeForm.ShutdownApp += OnShuttingDownApp;
            modeForm.Show();

            
            login.LoginSuccess -= OnLoginSuccess;
            login.FormClosed -= OnFormClosed;

            login.Close();
            
        }
        private void OnShuttingDownApp(object sender , EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to close the Application?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                modeForm?.Close();
            }
            else
                return;
        }
        private void OnOnlineModeSelected(object sender, EventArgs e)
        {
            var form1 = _provider.GetRequiredService<OnlineForm>();
            form1.InitializeUser(CurrentUser);
            form1.CloseOnlineMode += OnCloseOnlineMode;
            form1.FormClosed += OnFormClosed;
            form1.Show();

            if (sender is ModeSelectionForm f)
                f.Hide();
        }
        private void OnCloseOnlineMode(object sender , EventArgs e)
        {

            modeForm?.Show();

            if (sender is Form form1)
                form1.Close();
        }
        private void OnLogoutRequested(object sender , EventArgs e)
        {
            ShowLogin();

            if (sender is ModeSelectionForm mode)
            {
                mode.LogoutRequested -= OnLogoutRequested;
                mode.FormClosed -= OnFormClosed;
                mode.Close();
            }
        }

        private void OnFormClosed(object sender , FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                ExitThread();
        }

    }
}
