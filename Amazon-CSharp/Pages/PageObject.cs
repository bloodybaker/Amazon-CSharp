using NSelene;
using SeleniumExtras.PageObjects;

namespace FirstTestProject.Pages
{
    public class PageObject
    {
        protected SeleneDriver _driver;

        public PageObject(SeleneDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver,this);
        }
    }
}