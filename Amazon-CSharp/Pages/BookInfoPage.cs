using System;
using System.Collections.Generic;
using System.Text;
using NSelene;
using NSelene.Support.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FirstTestProject.Pages
{
    public class BookInfoPage : PageObject
    {
        private By title = By.XPath("//div[@id='titleblock_feature_div']//span[@id='productTitle']");
        private By bestSellerBage = By.XPath("//a[@class='badge-link']//i[@class='a-icon a-icon-addon p13n-best-seller-badge']");
        private By autorBlock = By.XPath("//span[@class='author notFaded']");
        
        protected List<Book> _books = new List<Book>();
        protected StringBuilder author = new StringBuilder();
        private SeleneCollection listofAuthors;
        public List<Book> AllBooks => _books;

        protected void CreateBook(string url)
        {
            _driver.Open(url);
            bool bestSeller;
            listofAuthors = _driver.FindAll(autorBlock);
            foreach (var a in listofAuthors)
            {
                author.Append(a.Text);
            }

            try
            {
                _driver.Find(bestSellerBage);
                bestSeller = true;
            }
            catch
            {
                bestSeller = false;
            }
            _books.Add(new Book(_driver.Find(title).Text, author.ToString(), bestSeller));
            author.Clear();
        }


        public BookInfoPage(SeleneDriver driver) : base(driver) {}
    }
}