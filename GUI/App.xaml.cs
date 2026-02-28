using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.IO;
using System.Windows;

namespace GUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider? Services { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var services = new ServiceCollection();

            // These variables are used to construct the database path
            var directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var dbPath = Path.Combine(directory, "uni.db");

            // TODO: Set up Dependency Injection for the SQL repository

            // TODO: NB! For the bonus task only! Set up EFCore repository for the AppDbContext
            // TODO: NB! For the bonus task only! Set up Dependency Injection for the EF Core repository

            Services = services.BuildServiceProvider();

            base.OnStartup(e);
        }
    }
}
