using DataTransfer;
using Domain.Objects.Abstracts;
using System;


namespace Domain.Objects
{
    public class Film : DataItemBase
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetValue(ref _title,value); }
        }

        private string _distribution;
        public string Distribution
        {
            get { return _distribution; }
            set {SetValue(ref _distribution, value); }
        }

        private string _productionCompany;
        public string ProductionCompany
        {
            get { return _productionCompany; }
            set { SetValue(ref _productionCompany, value); }
        }

        private string _type;
        public string Type
        {
            get { return _title; }
            set {SetValue(ref _type, value); }
        }

        private string _geners;
        public string Genres
        {
            get { return _geners; }
            set {SetValue(ref _geners, value); }
        }

        private string _reliseYear;
        public string ReliseYear
        {
            get { return _reliseYear; }
            set {SetValue(ref _reliseYear, value); }
        }

        private FilmStatus _filmStatus;
        public FilmStatus FilmStatus
        {
            get { return _filmStatus; }
            set {SetValue(ref _filmStatus, value); }
        }

        private FilmSoundTrack _soundTrack;
        public FilmSoundTrack SoundTrack
        {
            get { return _soundTrack; }
            set {SetValue(ref _soundTrack, value); }
        }


        public static Film FromDto(FilmDto film)
        {
            return new Film
            {
                Title = film.Title,
                Distribution = film.Distribution,
                FilmStatus = film.Status,
                SoundTrack = film.SoundTrack,
                Genres = film.Genres,
                ReliseYear = film.ReliseYear,
                ProductionCompany = film.ProductionCompany,
            };
        }

        public override string ToString()
        {
            return $"{Title} ({ReliseYear}) by : {Distribution}";
        }

        public override bool IsDirty()
        {
            if (Status == Status.Dirty || Status == Status.Deleted)
            {
                return true;
            }
            return false;
        }
    }
}
