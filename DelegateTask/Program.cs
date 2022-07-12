using System;
using System.Collections.Generic;

namespace DelegateTask
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Eshgin", "Sadiq", "Orxan", "Seid" };

            Name(CheckEshgin, list);
        }
        public static bool CheckEshgin(string name)
        {
            return name == "Eshgin";
        }
        public static void Name(Predicate<string> predicate, List<string> names)
        {
            foreach (var item in names)
            {
                if (predicate(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
    
}
