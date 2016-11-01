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
using AsistentoDelProyecto.Views;

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
        }

        private void InicializeWindow()
        {
            XmlConfigurator.Configure();
            InitializeComponent();
            EventHendlers();
            _filmService = new FilmService(Settings.Default.FilmFilePath);
            expander.Header = $"Films: {_filmService.GetAllItemsCount()}";

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

        private void EventHendlers()
        {
            taskbarIcon.TrayMouseDoubleClick += OnTrayMouseDoubleClick;
            newFilmButton.Click += NewFilmButton_Click;
        }

        private void NewFilmButton_Click(object sender, RoutedEventArgs e)
        {
            Log.Info("New Film Button clicked");
            FilmAdd filmAdd = new FilmAdd(_filmService);
            filmAdd.Closed += FilmAdd_Closed;
            filmAdd.ShowDialog();
        }

        private void FilmAdd_Closed(object sender, EventArgs e)
        {
            expander.Header = $"Films: {_filmService.GetAllItemsCount()}";
        }
    }
}
