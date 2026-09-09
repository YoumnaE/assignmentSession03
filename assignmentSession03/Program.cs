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


            Console.ReadLine();
        }
    }
}
