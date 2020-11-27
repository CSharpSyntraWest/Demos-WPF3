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

namespace Demos_controlsEnBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _isAangepast = false;
        }
        private bool _isAangepast;
        private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Je hebt mij open geklikt");
        }

        private void NewCommand(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("NewCommand uitgevoerd met " + e.Source.ToString());
            _isAangepast = false;
        }



        private void SaveCommand_Excecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("SaveCommand uitgevoerd met " + e.Source.ToString());
            _isAangepast = false;

        }
        private void SaveCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _isAangepast;

        }
        private  void OpenCommand(object sender, ExecutedRoutedEventArgs e)
        {
         
             MessageBox.Show("OpenCommand uitgevoerd met " + e.Source.ToString());
            _isAangepast = false;
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            _isAangepast = true;
        }
    }
}
