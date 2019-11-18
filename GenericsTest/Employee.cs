using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{
    public class Employee
    {
        public virtual void CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = 40 * wage;
            Console.WriteLine(" Empoloyee worked {0} hrs.  Paid £ {1} his take home id £ {2}", weeklyHours, wage, salary);


            Console.WriteLine(" ----------------------------------");

        }

    }
}
