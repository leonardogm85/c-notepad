using System.Windows;

namespace Notepad.View
{
    /// <summary>
    /// Interaction logic for AboutWindow.xaml
    /// </summary>
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        // Trata o evento de clique no botão OK, fechando a janela.
        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
