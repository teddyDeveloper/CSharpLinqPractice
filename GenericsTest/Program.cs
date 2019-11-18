using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{
   public class Program
    {

    
        

        static object book { get; set; } = "My Book";
        delegate void del(string value);
        static void Main(string[] args)
        {


            // Student s = new Student();
            // s.Name = "Teddy";
            // s.PrintName();

            // //del d = X => Console.WriteLine(X);
            // //d.Invoke(book.ToString());
            //// ReverseString("Hello World");
            //// LinqTest();
            ///

            const int hours = 50, wage = 70;
            Employee employee = new Employee();
            employee.CalculateWeeklySalary(hours, wage);

            Contractor contractor = new Contractor();
            contractor.CalculateWeeklySalary(hours, wage);

            Console.ReadLine();
        }

        private static void ReverseString(string str)
        {
            char[] CharrArray = str.ToCharArray();


            for (int i = 0, j = str.Length -1 ; i < j; i++, j--)
            {
                CharrArray[i] = str[j];
                CharrArray[j] = str[i];
            }

            string reversedstring = new string(CharrArray);
            Console.WriteLine(reversedstring);
            Console.ReadLine();

        }

        private static void LinqTest()
        {
           List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    

            var evenScores = numbers.Where(i => i % 2 == 0).ToList();

            foreach (var item in evenScores)
            {
                Console.WriteLine("{0}", item);
            }
           
            
        }
    }

 
}



