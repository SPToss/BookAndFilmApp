using NUnit.Framework;


namespace UnitTest.DomainTest
{
    public class FilmServiceTest : FilmServiceTestBase
    {
        [Test]
        public void AfterAddTwoFilmServiceShouldHaveTwoElement()
        {
            Actual = filmService.GetAllItemsCount();
            Expected = 2;
        }

        [Test]
        public void ServiceShouldHaveCategory()
        {
            Actual = filmService.CHeckForSerie("Test name");
            Expected = true;
        }
    }
}
