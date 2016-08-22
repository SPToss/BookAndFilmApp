using DataTransfer;
using Domain.Objects.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Objects
{
    public class FilmList : ListBase
    {
        private List<Film> _films;

        public FilmList()
        {
            _films = new List<Film>();
        }

        public FilmList(FilmDto film) : this(new List<FilmDto> { film } ) { }

        public FilmList(Film film) : this(new List<Film> { film } ) { }

        public FilmList(List<FilmDto> films)
        {
            _films = new List<Film>(films.Select(Film.FromDto).ToList());
        }

        public FilmList(List<Film> films)
        {
            _films = new List<Film>(films);
        }


        public void AddToList(Film film)
        {
            _films.Add(film);
        }

        public int Count()
        {
            return _films.Count;
        }
        public override bool IsDirty()
        {
            return _films.Any(x => x.IsDirty());
        }

        
    }
}
