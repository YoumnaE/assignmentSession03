using System.Text;

namespace assignmentSession03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ToUpper
            string title = "clean code";
            string upperTitle = title.ToUpper();

            Console.WriteLine(title);
            Console.WriteLine(upperTitle);

            #endregion


            #region Question 2

            string string1 = "Clean Code";
            string string2 = "Clean Code";
            Console.WriteLine(object.ReferenceEquals(string1, string2)); //true
            #endregion


            #region Question 3

            StringBuilder stringbuilder = new StringBuilder();
            stringbuilder.Append("Book List");
            stringbuilder.Append(" - Updated");
            Console.WriteLine(stringbuilder);

            #endregion

            #region Question 4

            stringbuilder.Replace("Book List", "Library");
            Console.WriteLine(stringbuilder);

            #endregion

            #region Question 5

            string title1 = "Clean Code";
            int pages = 464;
            string sentence = "Book:" + title1 + ", Pages:" + pages;
            Console.WriteLine(sentence);

            #endregion

            #region Question 6

            string sentence2 = $"Book: {title1}, Pages: {pages}";
            Console.WriteLine(sentence2);

            #endregion


            #region Question 7 

            string sentence3 = string.Format("Book: {0}, pages: {1}", title1, pages);
            Console.WriteLine(sentence3);

            #endregion

            #region Question 8

            if (pages >= 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }

            #endregion

            #region Question 9

            bool isAvailable = true;
            if (isAvailable && pages >= 300)
            {
                Console.WriteLine("You can borrow this book");
            }
            else if (!isAvailable)
            {
                Console.WriteLine("Not Available");
            }
            else { Console.WriteLine("too short"); }

            #endregion

            #region Question 10

            string title3 = "Refactoring";

            Console.WriteLine("Enter a Book Title: ");
            string bookTitle = Console.ReadLine();

            switch(bookTitle){
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;

                default: 
                    Console.WriteLine("Never heard of it");
                    break;
            }


            #endregion

            #region Question 11

            string message = pages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(message);

            #endregion

            #region Question 12

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            for (int i = 0; i < books.Length; i++) { 
            Console.WriteLine(i+1  + ". " + books[i]);
            }

            #endregion

            #region Question 13

            int j= 0;
            while(j< books.Length) { 
                Console.WriteLine(books[j]);
                j++;
                    }

            #endregion

            #region Question 14
            j = 0;
            do
            {
                Console.WriteLine("Checking book...");
                j++;
            } while (j < 3);

            #endregion

            #region Question 15

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }

            #endregion

            #region Question 16

            foreach (string book in books)
            {
                Console.WriteLine(book);

                if (title == "Refactoring")
                {
                    break;
                }
            }

            #endregion

            Console.ReadLine();
        }
    }
}
