using System;
using System.Collections.Generic;

namespace Delegate
{
    class Program
    {
        public delegate bool CheckNums(int num);
        public delegate void ChangeString(string str);
        public delegate int StrLength(string str);
        
        static void Main(string[] args)
            
        {
            #region Predicate,Action
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //Console.WriteLine(Sum(CheckOdd,arr));

            //Console.WriteLine(Sum(CheckEven, arr));

            //Console.WriteLine(Sum(CheckHigherFive,arr));
            //List<int> numbers = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = numbers.FindAll(m => m > 6);

            //var result2 = numbers.FindAll(CheckHigherFive);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Test(StringToUpper, "Cavid");
            //Test(StringToLower, "Cavid");

            //ChangeString changeString = new ChangeString(StringToLower);
            //changeString.Invoke("Orxan");

            //ChangeString change = StringToLower;
            //change += StringToUpper;
            //change += delegate (string s)
            // {
            //     Console.WriteLine(s.ToLower());
            // };
            //change += s => Console.WriteLine(s.ToUpper());

            //change("Orxan");

            //Action<int, string> action = StringToUpper;
            //action += StringToLower;
            //action(55, "Orxan");
            #endregion
            Console.WriteLine(Test(StringLength,"eshgin"));

            



        }
        public static int StringLength(string str)
        {
            return str.Length;
        }
        public static int Test(StrLength func, string str)
        {
            return func(str);
        }

        public static void StringToUpper(int n,string str)
        {
            Console.WriteLine(str.ToUpper());
        }
        public static void StringToLower(int n,string str)
        {
            Console.WriteLine(str.ToLower());
        }

        public static void Test(ChangeString func, string str)
        {
            func(str);
        }

        public static void Test() => Console.WriteLine("Tested");
        public static bool CheckOdd(int number)
        {
            return (number % 2 != 0);
        }

        public static bool CheckEven(int number)
        {
            return (number % 2 == 0);
        }

        public static bool CheckHigherFive(int number)
        {
            return (number > 5);
        }


        public static int Sum( Predicate<int> predicate, int[] nums)
        {
            var sum = 0;
            foreach (var item in nums)
            {
                if (predicate(item))
                {
                    sum += item;
                }
            }
            return sum;           
        }

        //public static int SumEven(CheckNums func, int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}

        //public static int SumMoreThanFive(CheckNums func, int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (func(item)) 
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}
    }
}
