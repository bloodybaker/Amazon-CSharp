using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NSelene;
using OpenQA.Selenium;

namespace FirstTestProject.Pages
{
    public class SearchPage : PageObject
    {
        
        private By _elements = By.XPath("//div[contains(@class,'s-main-slot')]//div[@data-index]//a[@class='a-link-normal a-text-normal']");
        private By _category = By.XPath("//span[text()='Books']");

        private ReadOnlyCollection<IWebElement> _categoryElements;
        
        private SeleneCollection _names;
        private List<string> _urls = new List<string>();
        public List<string> Urls ()=> _urls;
        public SearchPage(SeleneDriver driver) : base(driver) {}

        public void SetCategory()
        {
            _driver.Find(_category).Click();
        }

        public void GetElements()
        {
            _names = _driver.FindAll(_elements);
            for(int i = 0; i < _names.Count; i++)
            {
                _urls.Add(_names[i].GetAttribute("href"));
            }

            for (int i = 0; i < _urls.Count; i++)
            {
                if (_urls[i].Contains("true"))
                {
                    Console.WriteLine("Removed: " + _urls[i]);
                    _urls.Remove(_urls[i]);
                }
            }
        }

        public PageScraper Confirm()
        {
            SetCategory();
            GetElements();
            return new PageScraper(_driver);
        }
    }
}