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
                Type = film.Type
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

        public override int GetHashCode()
        {
            int result = (Title != null ? Title.GetHashCode() : 0);
            result = (result * 397) ^ (Distribution != null ? Distribution.GetHashCode() : 0);
            result = (result * 397) ^ (FilmStatus.GetHashCode());
            result = (result * 397) ^ (SoundTrack.GetHashCode());
            result = (result * 397) ^ (Genres != null ? Genres.GetHashCode() : 0);
            result = (result * 397) ^ (ReliseYear != null ? ReliseYear.GetHashCode() : 0);
            result = (result * 397) ^ (ProductionCompany != null ? ProductionCompany.GetHashCode() : 0);
            result = (result * 397) ^ (Type != null ? Type.GetHashCode() : 0);
            return result;
        }

        public bool CompareTo(Film obj)
        {
            return this.GetHashCode() == obj.GetHashCode();
        }
    }
}
