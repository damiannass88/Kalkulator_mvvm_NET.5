using Kalkulator_mvvm_NET._5.ModelViews;
using MahApps.Metro.Controls;

namespace Kalkulator_mvvm_NET._5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
