using DataTransfer;
using Domain.Objects.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Objects
{
    public class Films : IDataObject
    {
        public List<FilmSerie> FilmSeries { get; set; }

        public static Films FormDto(FilmsDto dto)
        {
            return new Films
            {
                FilmSeries = dto.FilmSeries.ConvertAll(x => FilmSerie.FromDto(x))
            };
        }

        public FilmsDto ToDto()
        {
            return new FilmsDto
            {
                FilmSeries = FilmSeries.ConvertAll(x => x.ToDto())
            };
        }

        public List<string> GetAllSeriesName()
        {
            return FilmSeries.Select(x => x.Name).ToList();
        }

        public FilmSerie GetSerieByName(string serieName)
        {
            if (!CheckForSerie(serieName))
            {
                return new FilmSerie();
            }
            return FilmSeries.First(x => x.Name == serieName);
        }

        public void AddSerie(FilmSerie filmSerie)
        {
            FilmSeries.Add(filmSerie);
        }

        public void AddFilmToSerie(string serieName, Film film)
        {
            FilmSeries.FirstOrDefault(x => x.Name == serieName).AddFilm(film);
        }

        public bool CheckForSerie(string serieName)
        {
            return FilmSeries.Any(x => x.Name == serieName);
        }

        public bool CheckForFilmInSerie(string serieName, Film film)
        {
            return FilmSeries.Any(x => x.Name == serieName && x.CheckForFilm(film));
        }

        public int CountAllElements()
        {
            return FilmSeries.Sum(x => x.GetFilmsCount());
        }

        public bool IsDirty()
        {
            return FilmSeries.Any(x => x.IsDirty());
        }
    }
}
