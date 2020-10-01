using FirstTestProject.Pages;
using NSelene;
using NSelene.Support.Extensions;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Amazon_CSharp
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(TestName = "Amazon Test")]
        public void EqualBook()
        {
            
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--window-position=0,0");
            options.AddArguments("--window-size=1920,1080");
            
            SeleneDriver driver = new SeleneDriver(new ChromeDriver());
            driver.Open("https://amazon.com");
            
            HomePage initPage = new HomePage(driver);
            initPage.FillField("Java");

            SearchPage search = initPage.Submit();

            PageScraper scraper = search.Confirm();
            
            CheckedBook checkedBook = scraper.InitComparableBook(search.Urls());
            
            Assert.True(checkedBook.IsEqual(scraper.allBooks));
            driver.Close();
        }
    }
}