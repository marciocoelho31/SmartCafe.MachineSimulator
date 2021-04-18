using SmartCafe.EventHub.Sender;
using SmartCafe.MachineSimulator.UI.ViewModel;
using System.Configuration;
using System.Windows;

namespace SmartCafe.MachineSimulator.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var eventHubConnectionString =
                ConfigurationManager.AppSettings["EventHubConnectionString"];
            DataContext = new MainViewModel(new CoffeeMachineDataSender(eventHubConnectionString));
        }
    }
}
