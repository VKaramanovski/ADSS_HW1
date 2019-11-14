using System;
using System.Collections.Generic;
using System.Linq;


namespace ADSS_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;



            Console.WriteLine("Enter a String:");
            str = Console.ReadLine();

            Console.WriteLine("The reversed String: {0}", Reverse(str));



            int primeN;

            Console.WriteLine("\nEnter an integer and see if its a prime number:");
            primeN = int.Parse(Console.ReadLine());
            if (IsPrime(primeN))
            {
                Console.WriteLine("It's a prime number");
            }
            else
            {
                Console.WriteLine("NOT A PRIME NUMBER");
            }




            int decNum;

            Console.WriteLine("\nEnter non-negative integer:");
            decNum = int.Parse(Console.ReadLine());
            Console.WriteLine(DescendingNumber(decNum));

        }

        public static string Reverse(string s)
        {
            char[] chArray = s.ToCharArray();
            Array.Reverse(chArray);
            return new string(chArray);
        }


        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }
            if (number % 2 == 0)
            {
                return false;
            }

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)

                if (number % i == 0)

                    return false;


            return true;

        }

        public static int DescendingNumber(int num)
        {
            List<int> listOfNums = new List<int>();

            while (num > 0)
            {
                listOfNums.Add(num % 10);
                num = num / 10;
            }
            listOfNums.Reverse();

            var newList = listOfNums.OrderByDescending(x => x).ToList();
            var newArray = newList.ToArray();

            int finalNum = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                finalNum += newArray[i] * Convert.ToInt32(Math.Pow(10, newArray.Length - i - 1));
            }

            return finalNum;






        }
    }
}
