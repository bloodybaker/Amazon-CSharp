using System;
using System.Collections.Generic;
using Amazon_CSharp;
using NSelene;

namespace FirstTestProject.Pages
{
    public class CheckedBook : BookInfoPage
    {
        public CheckedBook(SeleneDriver driver, string url) : base(driver)
        {
            CreateBook(url);
        }

        public bool IsEqual(List<Book> allBooks)
        {
            for (int i = 0; i < allBooks.Count; i++)
            {
                if(allBooks[i].Name.Equals(_books[0].Name) &&
                   allBooks[i].Author.Equals(_books[0].Author) &&
                   allBooks[i].BestSeller.Equals(_books[0].BestSeller)){
                    return true;
                }
            }
            return false;
        }
    }
}