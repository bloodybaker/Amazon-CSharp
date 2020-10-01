namespace FirstTestProject.Pages
{
    public class Book
    {
        private string _name;
        private string _author;
        private bool _bestSeller;

        public Book(string name, string author, bool bestSeller)
        {
            _name = name;
            _author = author;
            _bestSeller = bestSeller;
        }

        public string Name => _name;
        public string Author => _author;
        public bool BestSeller => _bestSeller;

        public override string ToString()
        {
            return "BookObject{" +
                          "name='" + Name + '\'' +
                          ", author='" + Author + '\'' +
                          ", bestSeller=" + BestSeller +
                          '}';
        }
    }
}