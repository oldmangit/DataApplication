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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            //InitializeBaseSettings();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;
            InitializeBaseSettings();
        }
        private void InitializeBaseSettings()
        {
            StartPosition = FormStartPosition.CenterScreen;
            //WindowState = FormWindowState.Maximized;
        }
    }
}
