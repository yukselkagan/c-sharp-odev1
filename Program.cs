using System;
using System.Collections.Generic;
using System.Linq;

namespace c_sharp_odev1
{
    class Program
    {
        static void Main(string[] args)
        {



            Method1();
            Method2();
            Method3();
            Method4();




        }



        public static void Method1()
        {
            Console.WriteLine("Enter a positive number");
            int numberCount = Convert.ToInt32(Console.ReadLine());

            List<int> numberList = new();
            Console.WriteLine($"Enter {numberCount} number");
            for (int i = 1; i <= numberCount; i++)
            {
                numberList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Even numbers: ");
            foreach (int item in numberList)
            {
                if( (item % 2) == 0)
                {
                    Console.WriteLine(item);
                }
            }

        }




        public static void Method2()
        {

            Console.WriteLine("Enter 2 positive number");

            Console.Write("First number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            List<int> numberList = new();
            Console.WriteLine($"Enter {number1} number");
            for (int i = 1; i <= number1; i++)
            {
                numberList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine($"Numbers can be divided by {number2} :");
            foreach (int item in numberList)
            {
                if ((item % number2) == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }



        public static void Method3()
        {

            Console.WriteLine("Enter a positive number");
            int number1 = Convert.ToInt32(Console.ReadLine());


            List<string> stringList = new List<string>();

            Console.WriteLine($"Enter {number1} word");
            for(int i=1; i <= number1; i++)
            {
                stringList.Add(Console.ReadLine());
            }

            stringList.Reverse();

            for(int i=0; i < stringList.Count; i++)
            {
                Console.WriteLine(stringList[i]);
            }

        }




        public static void Method4()
        {

            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();

            List<string> wordList = new List<string>();
            wordList = sentence.Split(" ").ToList();
            Console.WriteLine($"Sentence have {wordList.Count} word");
            string stringForCountLetters = string.Join("",wordList);
            Console.WriteLine($"Sentence have {stringForCountLetters.Length} letter");
            
        }




































    }
}
