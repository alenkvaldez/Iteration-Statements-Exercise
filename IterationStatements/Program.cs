﻿using Internal;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void printThousand()
        {
            for (int i = 1000; i >= -1000; i--);
            {
                Console.WriteLine(i);
            }
        
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void almostThousand()
        {
            for (int a = 3; a <= 999; a += 3);
            {
                Console.WriteLine(a);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void twoInt(int a, int b)
        {
            if (a == b)
                return true;
        }
            else
            {
                return false;
            }
        
        //Write a method to check whether a given number is even or odd
        public static void checkInt(int n)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("entered number is even number");
                }
                else
                {
                    Console.WriteLine("entered number is an odd number");
                }
            }

        //Write a method to check whether a given number is positive or negative
        public static void checkPosNeg(num)
        {
            if (num > 0)
            {
            Console.WriteLine("number is positive");
            }
            else if (num == 0)
                {
                    Console.WriteLine("number is 0");
                }
            else
                {
                    Console.WriteLine("number is negative");
                }
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void checkVote(age)
            {
                if (age >= 18)
                {
                    Console.WriteLine("eligible");
                }
                else
                {
                    Console.WriteLine("not eligible");
                }
            }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void checkInt() 
            {
                if (i > -10 && i < 10)    
            }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void quickMaths()
            {
                int n = 1;
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine (n + " * " + i + " = " + n * i + "\n");
                }
                
            }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
                printThousand();
                almostThousand();
                twoInt();
                checkInt()
                checkPosNeg()
                checkVote()
                checkInt()
                quickMaths()

                Console.WriteLine("hello");

        }
    }
}


 
