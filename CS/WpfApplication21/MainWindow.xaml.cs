using System.Windows;

namespace WpfApplication21 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            InitSources();
        }

        private void InitSources() {
            ProductList source = new ProductList();
            listBoxEdit1.ItemsSource = source;
            checkedListBoxEdit.ItemsSource = source;
            radioListBoxEdit.ItemsSource = source;
        }
    }
}
