using DataTransfer;
using System;
using log4net;
using System.Xml.Linq;

namespace DataAcces
{
    public class FilmDao
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(FilmDao));
        public bool SaveFilms(FilmsDto films)
        {
            try
            {
                var xelement = XmlHelper.SerializeToXElement(films);
                xelement.Save("E:\\Films.xml"); // TODO Add this to seting
                return true;
            }
            catch(Exception e)
            {
                Log.Error($"An error occured while saving data to file: {e}");
                return false;
            }
        }

        public FilmsDto LoadFilms(string path)
        {
            try
            {
                var root = XElement.Load(@path);
                var result = XmlHelper.Deserialize<FilmsDto>(root);
                Log.Debug($"Loaded {result} form {path}");
                return result;
            }
            catch (Exception e)
            {
                Log.Error($"Error occured while loading data {e}");
                throw;
            }    
        }
    }
}
