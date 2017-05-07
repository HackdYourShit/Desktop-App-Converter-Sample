using MahApps.Metro.Controls;

namespace DesktopAppSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            var helpers = new DesktopBridge.Helpers();
            if (helpers.IsRunningAsUwp())
            {
                PackageNameText.Text = Windows.ApplicationModel.Package.Current.DisplayName;
            } else
            {
                PackageNameText.Text = "Not running as UWP package";
            }
        }
    }
}
