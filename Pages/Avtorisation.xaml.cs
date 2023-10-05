using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sport.Pages
{
    /// <summary>
    /// Логика взаимодействия для Avtorisation.xaml
    /// </summary>
    public partial class Avtorisation : Page
    {
        public Avtorisation()
        {
            InitializeComponent();
        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            if(TxbLogin.Text == "1" && PsbParol.Password == "1")
            Classes.manager.MainFrame.Navigate(new Pages.Admin());
        }
    }
}
