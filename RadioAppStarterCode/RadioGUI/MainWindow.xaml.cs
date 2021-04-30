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
using RadioApp;

namespace RadioGUI
{
    public partial class MainWindow : Window
    {
        private Radio _radio = new Radio();
        private bool _on = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnOff_Click(object sender, RoutedEventArgs e)
        {
            if (_on == false)
            {
                _radio.TurnOn();
                _on = true;
            }
            else
            {
                _radio.TurnOff();
                _on = false;
            }
            LabelOutput.Content = _radio.Play();
        }
        private void channelChange_Click(object sender, RoutedEventArgs e)
        {
            if (_on == true)
            {
                int channel = Int32.Parse((sender as Button).Content.ToString());
                _radio.Channel = channel;
                LabelOutput.Content = _radio.Play();
            }
            else
            {
                LabelOutput.Content = _radio.Play();
            }

        }
    }
}
