using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;
using ClassLibrary.DataAccess;
using ClassLibrary;

namespace TeacherManagementSystemClient
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // This class will contains your injections
            var services = new ServiceCollection();
       
            // Configures your injections
            ConfigureServices(services);

            // Service provider is the one that solves de dependecies
            // and give you the implementations
            using (ServiceProvider sp = services.BuildServiceProvider())
            {
                // Locates `Form1` in your DI container.
                var form1 = sp.GetRequiredService<Form1>();
                // Starts the application
                Application.Run(form1);
            }

        }

        // This method will be responsible to register your injections
        private static void ConfigureServices(IServiceCollection services)
        { 
            services.AddSingleton<IDataAccess, DemoDataAccess>();
             

            // Inject MediatR
            services.AddMediatR(typeof(ClassLibraryMediatrEntryPoint).Assembly); // Assembly.GetExecutingAssembly());


            // As you will not be able do to a `new Form1()` since it will 
            // contains your injected services, your form will have to be
            // provided by Dependency Injection.
            services.AddScoped<Form1>();

        }
    }
}