using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace sfchart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            Task.Run(new Action(() => {

                while (true)
                {
                    Thread.Sleep(400);
                    this.Dispatcher.Invoke(new Action(() =>
                    {
                        this.SSS.ItemsSource = new ViewModel().Data;
                    }));
                }

                
            }));
        }
    }
}
