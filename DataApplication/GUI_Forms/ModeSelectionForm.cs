using DataApplication.Repository;
using DocumentFormat.OpenXml.Wordprocessing;
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
        public ModeSelectionForm(IUserRepository repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnOnlineMode_Click(object sender, EventArgs e)
        {
            OnlineModeSelected?.Invoke(this, EventArgs.Empty);
        }
    }
}
