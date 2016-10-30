using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using Hardcodet.Wpf.TaskbarNotification;
using log4net;
using log4net.Config;
using Domain.Services;
using AsistentoDelProyecto.Properties;
using System.Windows.Controls;

namespace AsistentoDelProyecto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(MainWindow));
        private FilmService _filmService;
        public MainWindow()
        {
            Log.Info("Started main App Window");
            InicializeWindow();

            taskbarIcon.TrayMouseDoubleClick += new RoutedEventHandler(OnTrayMouseDoubleClick);            
        }
                
        private void InicializeWindow()
        {
            XmlConfigurator.Configure();
            InitializeComponent();
            _filmService = new FilmService(Settings.Default.FilmFilePath);
            filmsButton.Content = $"Films: {_filmService.GetAllItemsCount()}";
            
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
