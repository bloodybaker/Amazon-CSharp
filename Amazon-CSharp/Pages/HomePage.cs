using System;
using NSelene;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FirstTestProject.Pages
{
    public class HomePage : PageObject
    {
        private IWebElement _field;
        private By _nav = By.ClassName("nav-input");

        public HomePage(SeleneDriver driver) : base(driver) {}

        public void FillField(string iostring)
        {
            _field = _driver.Find(_nav);
            _field.SendKeys(iostring);
            
        }

        public SearchPage Submit()
        {
            _field.Submit();
            return new SearchPage(_driver);
        }
    }
}