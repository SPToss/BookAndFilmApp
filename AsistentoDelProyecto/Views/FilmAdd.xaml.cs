﻿using Domain.Services;
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
using System.Windows.Shapes;
using log4net;
using DataTransfer;

namespace AsistentoDelProyecto.Views
{
    /// <summary>
    /// Interaction logic for FilmAdd.xaml
    /// </summary>
    public partial class FilmAdd : Window
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(FilmAdd));
        FilmService _service;
        public FilmAdd(FilmService service)
        {
            InitializeComponent();
            _service = service;
            EventHendlers();
            statustComboBox.ItemsSource = Enum.GetValues(typeof(FilmStatus)).Cast<FilmStatus>();
            statustComboBox.SelectedIndex = 0;
            soundTrackCombomox.ItemsSource = Enum.GetValues(typeof(FilmSoundTrack)).Cast<FilmSoundTrack>();
            soundTrackCombomox.SelectedIndex = 0;
            Log.Info("Inicialized Add Film window");
        }

        private void EventHendlers()
        {
            cancelButton.Click += CancelButton_Click;
            addButon.Click += AddButon_Click;
        }

        private bool ValidateInput()
        {
            bool result = true;
            if (string.IsNullOrWhiteSpace(filmNameTextBox.Text) || filmNameTextBox.Text == "FilmName")
            {
                result = false;
                filmNameTextBox.BorderBrush = Brushes.Red;
            }
            if (string.IsNullOrWhiteSpace(filmGenersTextBox.Text) || filmGenersTextBox.Text == "Geners")
            {
                result = false;
                filmGenersTextBox.BorderBrush = Brushes.Red;
            }
            if (string.IsNullOrWhiteSpace(filmTypeTextBox.Text) || filmTypeTextBox.Text == "Type")
            {
                result = false;
                filmTypeTextBox.BorderBrush = Brushes.Red;
            }
            return result;
        }

        private void RestoreBorderChange()
        {
            filmNameTextBox.ClearValue(BorderBrushProperty);
            filmGenersTextBox.ClearValue(BorderBrushProperty);
            filmTypeTextBox.ClearValue(BorderBrushProperty);
        }

        private void AddButon_Click(object sender, RoutedEventArgs e)
        {

            RestoreBorderChange();
            if (!ValidateInput())
            {
                MessageBoxResult result = MessageBox.Show("Validation failed\nCorrect fields highlighted red", "Validation", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Log.Info("Closing Add Film window");
            this.Close();
        }
    }
}