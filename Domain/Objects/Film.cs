using DataTransfer;
using Domain.Objects.Abstracts;
using System;


namespace Domain.Objects
{
    public class Film : DataItemBase
    {
        public string Title { get { return Title; } set { Title = SetValue(value); } }
        public string Distribution { get { return Distribution; } set { Distribution = SetValue(value); } }
        public string ProductionCompany { get { return ProductionCompany; } set { ProductionCompany = SetValue(value); } }
        public string Type { get { return Type; } set { Type = SetValue(value); } }
        public string Genres { get { return Genres; } set { Genres = SetValue(value); } }
        public string ReliseYear { get { return ReliseYear; } set { ReliseYear = SetValue(value); } }
        public FilmStatus FilmStatus { get { return FilmStatus; } set { FilmStatus = SetValue(value); } }
        public FilmSoundTrack SoundTrack { get { return SoundTrack; } set { SoundTrack = SetValue(value); } }




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
        protected override bool IsDirty()
        {
            if(Status == Status.Dirty || Status == Status.Deleted)
            {
                return true;
            }
            return false;
        }
    }
}
