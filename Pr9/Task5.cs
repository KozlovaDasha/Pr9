using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr9
{
    delegate int UseOperation(int a, int b);
    delegate void GetGreeting();

    class Task5
    {
        //public static void Main()
        //{
        //    CallGetGreetingMethod();
        //    CallUseOperation();

        //    Console.ReadLine();
        //}

        #region GetGreeting
        
        private static GetGreeting greeting;

       
        public static void CallGetGreetingMethod()
        {
            if(DateTime.Now.Hour >= 4 && DateTime.Now.Hour < 11)
            {
                greeting += GoodMorning;
            }
            if(DateTime.Now.Hour >= 11 && DateTime.Now.Hour < 16)
            {
                greeting += GoodDay;
            }
            if(DateTime.Now.Hour >= 16 && DateTime.Now.Hour < 22)
            {
                greeting += GoodEvening;
            }
            if (DateTime.Now.Hour >= 22 && DateTime.Now.Hour < 4)
            {
                greeting += GoodNight;
            }

            greeting();
        }

        public static void GoodMorning()
        {
            Console.WriteLine("GOOD MORNING!");
        }
        
        public static void GoodDay()
        {
            Console.WriteLine("GOOD DAY!");
        }
        
        public static void GoodEvening()
        {
            Console.WriteLine("GOOD EVENING!");        
        }

        public static void GoodNight()
        {
            Console.WriteLine("GOOD NIGHT!");
        }
        #endregion

        #region UseOperation
       
        private static UseOperation someOP;

        
        public static void CallUseOperation()
        {
            int a, b = 0;
            Console.WriteLine("Enter two integer values");
            Console.Write("a: ");
            while (int.TryParse(Console.ReadLine(), out a) == false)
            {
                Console.Write("Wrong value! Try again: ");
            }

            Console.Write("b: ");
            while (int.TryParse(Console.ReadLine(), out b) == false)
            {
                Console.Write("Wrong value! Try again: ");
            }

            Console.WriteLine("Choose your action\n1 - Sum\n2 - Difference\n3 - Multiply\n4 - Divide");
            int choice = new int();
            while (int.TryParse(Console.ReadLine(), out choice) == false)
            {
                Console.Write("Wrong value! Try again: ");
            }
            switch (choice)
            {
                case 1:
                    someOP += Sum;
                    Console.WriteLine($"Here is the sum: {someOP(a, b)}");
                    break;
                case 2:
                    someOP += Difference;
                    Console.WriteLine($"Here is the difference: {someOP(a, b)}");
                    break;
                case 3:
                    someOP += Multiply;
                    Console.WriteLine($"Here is multiply result: {someOP(a, b)}");
                    break;
                case 4:
                    someOP += Divide;
                    Console.WriteLine($"Here is the dividing result: {someOP(a, b)}");
                    break;
                default:
                    break;
            }


        }
       
        public static int Sum(int a, int b)
        {
            return a + b;
        }
   
        public static int Difference(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        #endregion
    }


}
