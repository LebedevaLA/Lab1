using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Person : IPerson
    {
        public Person()
        {
            CardNumber = 0;
            Name = "";
        }
        public Person(int c, string n, DateTime b)
        {
            CardNumber = c;
            Name = n;
            Bithday = b;
        }
        public int CardNumber{ get; set; }

        public string Name { get; set; }

        public DateTime Bithday { get; set; }

        public int calcAge(DateTime dateBithday)
        {
            DateTime now = DateTime.Now;
            int a = now.Year;
            int b = dateBithday.Year;
            int ans = a - b;
            if (dateBithday.Month > now.Month)
            {
                ans -= 1;
            } else if (dateBithday.Month == now.Month && now.Day < dateBithday.Day)
            {
                ans -= 1;
            }
            return ans;
        }
    }
}
