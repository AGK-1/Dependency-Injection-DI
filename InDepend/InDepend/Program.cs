using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace InDepend
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }


        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<ISingletonRandomService, SingletonRandomService>();
            services.AddTransient<ITransientRandomService, TransientRandomService>();
            services.AddScoped<IScopedRandomService, ScopedRandomService>();

            services.AddScoped<Form1>(); // Register the main form as scoped
        }
    }
}