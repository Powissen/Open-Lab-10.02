using System;

namespace Open_Lab_10._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            //LOTR.title = "Title";    
            //Console.WriteLine(LOTR.title);
            LOTR.Title();
            LOTR.Pages();
            LOTR.Cathegory();
            LOTR.Author();
            LOTR.ReleaseDate();
            Console.WriteLine(LOTR.ToString());
        }
    }
    public class Book
    {
        private string title;
        private int pages;
        private string cathegory;
        private string author;
        private string releaseDate;

        public void Title() { title = "Title"; }
        public void Pages() { pages = 1; }
        public void Cathegory() { cathegory = "Cathegory"; }
        public void Author() { author = "Author"; }
        public void ReleaseDate() { releaseDate = "ReleaseDate"; }


        public override string ToString()
        {
            string output = title + pages + cathegory + author + releaseDate;
            return output;
        }
    }
}
