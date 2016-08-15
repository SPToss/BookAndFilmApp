using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using Hardcodet.Wpf.TaskbarNotification;

namespace AsistentoDelProyecto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InicializeWindow();

            taskbarIcon.TrayMouseDoubleClick += new RoutedEventHandler(OnTrayMouseDoubleClick);            
        }
                
        private void InicializeWindow()
        {
            InitializeComponent();
        }

        protected override void OnStateChanged(EventArgs e)
        {
            if (WindowState == System.Windows.WindowState.Minimized)
            {
                this.Hide();
                taskbarIcon.Visibility = Visibility.Visible;
            }
            else
            {
                taskbarIcon.Visibility = Visibility.Hidden;
            }
            
            base.OnStateChanged(e);
        }

        private void OnTrayMouseDoubleClick(object sender, RoutedEventArgs args)
        {
            this.Show();
            this.WindowState = WindowState.Normal;
        }
    }
}
