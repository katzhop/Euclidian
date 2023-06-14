using System;

namespace Euclidian
{
    class Program
    {
        public static int Euclidian(int a, int b)
        {
            int r = a % b;
            if (r == 0)
            {
                return b;
            }
            else
            {
                return Euclidian(b, r);
            }
        }
        public static void Main(string[] args)
        {
            bool stop = false;
            Console.WriteLine("Enter Integer 1: ");
            int i1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Integer 2: ");
            int i2 = Convert.ToInt32(Console.ReadLine());
            while (stop == false)
            {
                Console.WriteLine("-----------------MAIN MENU---------------------------\n" +
                    "1. Enter Integers\n2. Find GCF\n3. Exit program\nEnter option number: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Integer 1: ");
                        i1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Integer 2: ");
                        i2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        int GCF = Euclidian(i1, i2);
                        Console.WriteLine("The GCF for " + i1 + " and " + i2 + ":\t" + GCF);
                        break;
                    case 3:
                        stop = true;
                        break;
                    default:
                        Console.WriteLine("Enter a valid option: ");
                        break;
                }
            }
        }
    }
}
