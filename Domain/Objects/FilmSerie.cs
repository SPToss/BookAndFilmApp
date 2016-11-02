using DataTransfer;
using Domain.Objects.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Objects
{
    public class FilmSerie : DataItemBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetValue(ref _name, value); }
        }

        private string _category;
        public string Category
        {
            get { return _category; }
            set { SetValue(ref _category, value); }
        }

        public List<Film> Films { get; set; }

        public override bool IsDirty()
        {
            if (Status == Status.Dirty || Status == Status.Deleted ||Films.Any(x => x.IsDirty()) )
            {
                return true;
            }
            return false;
        }

        public bool CheckForFilm(Film film)
        {
            return Films.Any(x => x.Equals(film));
        }

        public void AddFilm(Film film)
        {
            Films.Add(film);
        }

        public static FilmSerie FromDto(FilmSeriesDto dto)
        {
            return new FilmSerie
            {
                Category = dto.Category,
                Name = dto.Name,
                Films = dto.Films.ConvertAll(x => Film.FromDto(x))
            };
        }

        public int GetFilmsCount()
        {
            return Films.Count();
        }
    }
}
