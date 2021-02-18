using System;
using System.Collections.Generic;

namespace TheDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> theSurname = new Dictionary<int, string>();
            theSurname.Add(24, "Yılmaz");
            theSurname.Add(21, "Ak");
            theSurname.Add(18, "Kara");


            Surname<int, string> surname = new Surname<int, string>();
            surname.Add(10, "yılmaz");

            surname.List();
            int result = surname.Count;
            Console.WriteLine(result);

        }
    }
}
