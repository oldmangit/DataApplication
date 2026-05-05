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
            services.AddTransient<ModeSelectionForm>();

            services.AddSingleton<AppController>();

            var provider = services.BuildServiceProvider();

            var app = provider.GetRequiredService<AppController>();
            app.Run();
            
        }
    }
}