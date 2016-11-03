using NUnit.Framework;
using Domain.Objects;
using Domain.Services;
using System.Collections.Generic;

namespace UnitTest.DomainTest
{
    public abstract class FilmServiceTestBase
    {
        protected FilmService filmService;
        protected object Expected;
        protected object Actual;
        [SetUp]
        public void BeforeEach()
        {
            var films = new Films
            {
                FilmSeries = new List<FilmSerie>
                {
                    new FilmSerie
                    {
                        Category = "Test category",
                        Name = "Test name",
                        Films = new List<Film>
                        {
                            new Film
                            {
                                Distribution = "Test Distribution 1",
                                FilmStatus = DataTransfer.FilmStatus.Canceled,
                                Genres = "Test Geners 1",
                                ProductionCompany = "Test Company 1",
                                ReliseYear = "2014/05/05",
                                SoundTrack = DataTransfer.FilmSoundTrack.Dubbing,
                                Title = "Test Title 1",
                                Type = "Test Type 1"
                            },
                            new Film
                            {
                                Distribution = "Test Distribution 2",
                                FilmStatus = DataTransfer.FilmStatus.Canceled,
                                Genres = "Test Geners 2",
                                ProductionCompany = "Test Company 2",
                                ReliseYear = "2014/05/05",
                                SoundTrack = DataTransfer.FilmSoundTrack.Dubbing,
                                Title = "Test Title 2",
                                Type = "Test Type 2"
                            }
                        }
                    }
                }
            };
            filmService = new FilmService(films,"");
        }
        [TearDown]
        public void AfterAll()
        {
            Assert.AreEqual(Expected, Actual);
        }
    }
}
