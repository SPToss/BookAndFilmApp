using Domain.Objects;
using Domain.Objects.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcces;
using log4net;

namespace Domain.Services
{
    public class FilmService : BaseService<Films>
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(FilmService));
        public FilmService(string file) : base(file) { }

        public FilmService(Films films,string file) : base(films,file) { }

        public override void LoadData()
        {
            Log.Debug("Atempt to load data for FilmService");
            var dao = new FilmDao();
            Item = Films.FormDto(dao.LoadFilms(filePath));
        }
    }
}
