using System;
using System.Collections.Generic;
using NSelene;

namespace FirstTestProject.Pages
{
    public class PageScraper : BookInfoPage
    {
        private List<string> _urls;
        public List<Book> allBooks; 
        public PageScraper(SeleneDriver driver) : base(driver) {}
        
        private void ScrapBooks()
        {
            foreach (var url in _urls)
            {
                CreateBook(url);
            }

            allBooks = AllBooks;
        }

        public CheckedBook InitComparableBook(List<String> urls)
        {
            _urls = urls;
            ScrapBooks();
            return new CheckedBook(_driver, "https://www.amazon.com/Head-First-Java-Kathy-Sierra/dp/0596009208/ref=sr_1_3");
        }
        
    }
}