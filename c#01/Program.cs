using System.Dynamic;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Timers;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.WebRequestMethods;

namespace c_01
{
    #region q1,q2


    /*
    class Book
    {
        public string title = default!;
        public int pages;
    }
    */
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1,Q2
            //Create a Book class with a Title(string) and Pages(int). Create a Book object and store it in a variable of type object.Print it.

            //Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.


            /*
                Book b = new Book();
                object obj = b;
                Console.WriteLine(obj);
                Console.WriteLine(b.ToString());
                Console.WriteLine(b.Equals(b));
                Console.WriteLine(b.GetHashCode());
                Console.WriteLine(b.GetType());
                */
            #endregion
            #region q3
            //Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it.
            //int pages = "464";

            //int pages="495" this is a logical error it should be int pages=495;

            #endregion
            #region q4
            /*
                try
                {
                    int x = 10;
                    int y = 0;
                    Console.WriteLine(x / y)

                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("cannot divide by zero");
                }
                finally
                {
                    Console.WriteLine("done");
                }
                */
            #endregion
            #region Q5
            /*
                int pages = 300;
                double v = pages;
                */
            #endregion
            #region Q6
            /*
               double price = 49.99;
               int p = Convert.ToInt32(price);
               */
            #endregion
            #region Q7
            //Given string pagesText = "464";, convert it into an int using the Convert class.
            /*
            string pagestext = "464";
            int pt = Convert.ToInt32(pagestext);
            */
            #endregion
            #region Q8
            //Given string yearText = "2023";, convert it using int.Parse().Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            /*
               string yeartext = "2023";

               int yr = int.Parse(yeartext);
              
                string badtext = "abc";

                if(int.TryParse(badtext,out int v))
                {
                    Console.WriteLine("validnumber");
                    Console.WriteLine(v);
                }
                else
                {
                    Console.WriteLine("invalid");
                }
                */

            #endregion
           




        }
    }
}
