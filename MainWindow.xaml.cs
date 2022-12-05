using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();//считывает XAML компоненты, создает компоненты

            NewProject.Title = "NewProject"; //X:Name

            //создаем кнопку
            //Button btn = new Button();
            //btn.Content = "BTN";
            //btn.Width = 50;
            //btn.Height = 50;
            //NewProject.Content = btn;
        }

        private void btnShowAlert_Click(object sender , RoutedEventArgs e) //с кем происходит, что происходит
        {
            Button btn = (Button)sender;

            MessageBox.Show("FUCK YOU - "+DateTime.Now);
        }

        private void BtnSentMsg_OnClick(object sender, RoutedEventArgs e)
        {
            bool result = false;
            lblMessage.Content =  Helper.SenttMsg(tbxTo.Text, tbxSubject.Text, 
                tbxBody.Text, out result);

            if (!result)
            {
                
                lblMessage.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                
                lblMessage.Foreground = new SolidColorBrush(Colors.Green);
            }
        }
    }
}
