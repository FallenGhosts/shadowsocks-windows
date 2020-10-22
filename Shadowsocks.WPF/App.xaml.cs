
using System.Windows;

namespace Shadowsocks.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Client.Startup();

            //Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetCallingAssembly());
        }
    }
}
