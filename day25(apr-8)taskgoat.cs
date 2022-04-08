using System;
using System.Collections.Generic;
using System.Text;

namespace lynq
{
    class taskgoat
    {
       public static int numgoat(int legs,int eyes)
        {
            int num = 0;
            num = (legs - (eyes - 1)) / 2;
            return num;

        }
        public static void Main()
        {
            int eyes=52,legs=80;
            int goat = numgoat(legs, eyes);
            
            Console.WriteLine("no_of_goat is:"+goat);
            Console.WriteLine("no_of_duck is:"+ (goat - 2));

        }
    }
}
