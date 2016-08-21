using NUnit.Framework;
using Domain.Objects;

namespace UnitTest.DomainTest
{
    [TestFixture]
    public class FilmTest
    {
        [Test]
        public void NewObjectShouldHaveNewFlag()
        {
            Film film = new Film();

            Assert.That(film.Status.Equals(Status.New));
        }
        [Test]
        public void NewNotEmptyObjectShouldHaveNewFlag()
        {
            Film film = new Film
            {
                Distribution = "Test",
                FilmStatus = DataTransfer.FilmStatus.ToWatch,
                Genres = "Test",
                ProductionCompany = "Test"
            };
            Assert.That(film.Status.Equals(Status.New));
        }
    }
}
