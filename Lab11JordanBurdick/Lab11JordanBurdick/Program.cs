using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11JordanBurdick
{
    class Program
    {
        static void Main(string[] args)
        {
            //part 1
            Console.WriteLine("== Part 1 ==");
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            Console.WriteLine(names[2].Substring(6));
            
            //part 2
            string[] Months = new string[12];
            Console.WriteLine("== Part 2 ==");

            Months[0] = "Janurary";
            Months[1] = "Feburary";
            Months[2] = "March";
            Months[3] = "April";
            Months[4] = "May";
            Months[5] = "June";
            Months[6] = "July";
            Months[7] = "August";
            Months[8] = "September";
            Months[9] = "October";
            Months[10] = "November";
            Months[11] = "December";

            int m = -1;
            while (m < 11)
            {
                m++;
                Console.WriteLine("{0} {1}",m + 1,Months[m]);
            }

            //part 3
            string[] Seasons = new string[5];
            Seasons[0] = "Spring";
            Seasons[1] = "Summer";
            Seasons[2] = "Fall";
            Seasons[3] = "Winter";
            Console.WriteLine("== Part 3 ==");
            int f;
            for (f = 0; f <= 4; f++)
            {
                Console.WriteLine(Seasons[f]);
            }
            
            //part 4
            int[] Numbers = new int[1000];

            Random random = new Random();
            int randomnumber;

            int l = 0;
            for (l = 0; l <= 999; l++)
            {
                randomnumber = random.Next(0, 100);
                Numbers[l] = randomnumber;
                //Console.Write(l);
            }

            foreach (int DifferentRandomNumber in Numbers)
            {
                Console.WriteLine(DifferentRandomNumber);
                //Console.WriteLine(l);
            }

            //pls 
        }
    }
}
