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
        public bool IsDirty()
        {
            return FilmSeries.Any(x => x.IsDirty());
        }
    }
}
