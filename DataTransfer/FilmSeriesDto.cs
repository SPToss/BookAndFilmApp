using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
    public class FilmSeriesDto
    {
        public string Name { get; set; }

        public string Category { get; set; }

        public List<FilmDto> Films { get; set; }


    }
}
