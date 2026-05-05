using DataApplication.GUI_Forms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApplication
{
    public class AppController
    {
        private readonly IServiceProvider _provider;

        public AppController(IServiceProvider provider)
        {
            _provider = provider;
        }

        public void Run()
        {
            while (true)
            {
                var login = _provider.GetRequiredService<LoginForm>();

                var loginResult = login.ShowDialog();

                if (loginResult != DialogResult.OK)
                    break; // Exit app

                var mode = _provider.GetRequiredService<ModeSelectionForm>();

                var modeResult = mode.ShowDialog();

                if (modeResult != DialogResult.Retry)
                    break; // Exit app if not logout
            }
        }
    }
}
