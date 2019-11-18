using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{
    public class Contractor : Employee
    {
        public override void CalculateWeeklySalary(int weeklyHours, int wage)
        {
            base.CalculateWeeklySalary(weeklyHours, wage);

            var salary = weeklyHours * wage;
            Console.WriteLine(" Empoloyee worked {0} hrs.  Paid £ {1} his take home id £ {2}", weeklyHours, wage, salary);


        }
    }
}
