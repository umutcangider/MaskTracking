using System;
using System.Reflection.Metadata;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables();

            //Citizen citizen1 = new Citizen();    // instance

            //SayHi("Umutcan");
            //int total = Topla(3,7);


            // Arrays (Diziler)
            string student1 = "Umut";
            string student2 = "Can";
            string student3 = "Ali";

            Console.WriteLine(student1); Console.WriteLine(student2); Console.WriteLine(student3);

            string[] students = new string[3];
            students[0] = "Umut";
            students[1] = "Can";
            students[2] = "Ali";

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            string[] cities = new[] {"Ankara", "İstanbul", "İzmir"};
            string[] cities2 = new[] { "Bursa", "Antalya", "Kırklareli" };

            cities = cities2;
            cities[0] = "Adana";
            Console.WriteLine(cities2[0]); // Adana 

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            List<string> newCities = new List<string> { "Ankara", "İstanbul", "İzmir" };
            newCities.Add("Kırklareli");

            foreach (var city in newCities)
            {
                Console.WriteLine(city);
            }


            Console.ReadLine();
        }

        static void SayHi(string name="null")
        {
            Console.WriteLine("Hello!" + name);
        }

        static int Topla(int number1, int number2)
        {
            int total = number1 + number2;
            Console.WriteLine("Total = " + total.ToString());
            return total ;
        }

        private static void Variables()
        {
            string message = "Merhaba";
            double amount = 100000; // db'den gelir.
            int number = 100;
            bool isLogin = false;

            string name = "Umutcan";
            string surname = "Gider";
            int birthyear = 1997;
            long identificationNumber = 12345678910;

            Console.WriteLine(message);
        }
    }

    // Pascal Casing
    public class Citizen
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Brithyear { get; set; }
        public long IdentificationNumber { get; set; }

    }
}