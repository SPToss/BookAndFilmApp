using Domain.Services;
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
using Domain.Objects;

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
            categoryCombo.ItemsSource = _service.GetAllFilmSerieNmes();
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
            if (string.IsNullOrWhiteSpace(categoryCombo.Text))
            {
                result = false;
                categoryCombo.BorderBrush = Brushes.Red;
            }
            return result;
        }

        private void RestoreBorderChange()
        {
            filmNameTextBox.ClearValue(BorderBrushProperty);
            filmGenersTextBox.ClearValue(BorderBrushProperty);
            filmTypeTextBox.ClearValue(BorderBrushProperty);
            categoryCombo.ClearValue(BorderBrushProperty);
        }

        private void AddButon_Click(object sender, RoutedEventArgs e)
        {
            bool added = false;
            RestoreBorderChange();
            if (!ValidateInput())
            {
                MessageBoxResult result = MessageBox.Show("Validation failed\nCorrect fields highlighted red", "Validation", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                var film = BuildFilmSerie();
                var filmSerie = _service.GetSerieByName(categoryCombo.Text);
                if (!filmSerie.CheckForFilm(film))
                {
                    _service.AddFilmToSerie(filmSerie.Name, film);
                    added = true;
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Validation failed\nThis film is already in base", "Validation", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            if (added)
            {
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Log.Info("Closing Add Film window");
            this.Close();
        }

        private Film BuildFilmSerie()
        {  
            return new Film
            {
                Distribution = filmDistributionTextBox.Text,
                FilmStatus = (FilmStatus)Enum.Parse(typeof(FilmStatus), statustComboBox.Text, true),
                Genres = filmGenersTextBox.Text,
                ProductionCompany = filmProductionCompanyTextBox.Text,
                ReliseYear = filmDataPicker.Text,
                SoundTrack = (FilmSoundTrack)Enum.Parse(typeof(FilmSoundTrack), soundTrackCombomox.Text, true),
                Title = filmNameTextBox.Text,
                Type = filmTypeTextBox.Text
            };
        }
    }
}
