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
            Console.ReadLine();
        }
    }
}
