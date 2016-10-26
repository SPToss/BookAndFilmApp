using System;
using System.Collections.Generic;
using log4net;
using DataTransfer;
using DataAcces;
using System.Xml.Linq;

namespace DebugConsole
{

    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            //var film = new FilmsDto
            //{
            //    FilmSeries = new List<FilmSeriesDto>
            //    {
            //        new FilmSeriesDto
            //        {
            //            Category = "Test",
            //            Name = "Test",
            //            Films = new List<FilmDto>
            //            {
            //                new FilmDto
            //                {
            //                    Distribution = "Test",
            //                     Genres = "Test",
            //                     ProductionCompany = "Test",
            //                      ReliseYear = "231",
            //                      SoundTrack = FilmSoundTrack.Dubbing,
            //                      Status = FilmStatus.Canceled,
            //                      Title = "Test",
            //                      Type = "Test"
            //                },                            new FilmDto
            //                {
            //                    Distribution = "Test",
            //                     Genres = "Test",
            //                     ProductionCompany = "Test",
            //                      ReliseYear = "231",
            //                      SoundTrack = FilmSoundTrack.Dubbing,
            //                      Status = FilmStatus.Canceled,
            //                      Title = "Test",
            //                      Type = "Test"
            //                }
            //            }
            //        },
            //                            new FilmSeriesDto
            //        {
            //            Category = "Test",
            //            Name = "Test",
            //            Films = new List<FilmDto>
            //            {
            //                new FilmDto
            //                {
            //                    Distribution = "Test",
            //                     Genres = "Test",
            //                     ProductionCompany = "Test",
            //                      ReliseYear = "231",
            //                      SoundTrack = FilmSoundTrack.Dubbing,
            //                      Status = FilmStatus.Canceled,
            //                      Title = "Test",
            //                      Type = "Test"
            //                },                            new FilmDto
            //                {
            //                    Distribution = "Test",
            //                     Genres = "Test",
            //                     ProductionCompany = "Test",
            //                      ReliseYear = "231",
            //                      SoundTrack = FilmSoundTrack.Dubbing,
            //                      Status = FilmStatus.Canceled,
            //                      Title = "Test",
            //                      Type = "Test"
            //                }
            //            }
            //        }
            //    }
            //};

            //var test = XmlHelper.SerializeToXElement(film);

            //test.Save("E:\\Test.xml");
            log4net.Config.XmlConfigurator.Configure();
            Log.Info($"Trest{Log}");

            XElement root = XElement.Load("E:\\Test.xml");

            var filmn = XmlHelper.Deserialize<FilmsDto>(root);
        }
    }
}
