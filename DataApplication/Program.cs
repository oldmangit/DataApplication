using DataApplication.Data;
using DataApplication.GUI_Forms;
using DataApplication.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataApplication
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var config = new ConfigurationBuilder().SetBasePath(AppContext.BaseDirectory)
                                                    .AddJsonFile("appsettings.json", optional: false).Build();

            var services = new ServiceCollection();
            services.AddSingleton<IConfiguration>(config);
            services.AddSingleton<DbFactory>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<Form1>();
            services.AddTransient<LoginForm>();

            var provider = services.BuildServiceProvider();
            var login = provider.GetRequiredService<LoginForm>();

           
            if (login.ShowDialog() == DialogResult.OK)
            {
                var mainForm = provider.GetRequiredService<Form1>();
                Application.Run(mainForm);
            }
            else
            {
                //User closed login or failed
                Application.Exit();
            }
        }
    }
}