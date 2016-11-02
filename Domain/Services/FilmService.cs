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
        public override void SaveData()
        {

        }
        public bool CHeckForSerie(string serieName)
        {
            return Item.CheckForSerie(serieName);
        }

        public bool CheckForFilmInSerie(string serieName, Film film)
        {
            return Item.CheckForFilmInSerie(serieName, film);
        }

        public void AddFilmToSerie(string serieName, Film film)
        {
            Item.AddFilmToSerie(serieName, film);
        }

        public void AddSerie(FilmSerie filmSerie)
        {
            Item.AddSerie(filmSerie);
        }
    }
}
