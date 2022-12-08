using System.Collections.Generic;

namespace Prime.Models
{
    public class Number 
    {
        public static bool isPrime(int num) 
        {
            bool prime = true;
            List<int> basePrime = new List<int>{2, 3, 5, 7};
            foreach(int i in basePrime)
            {
                if(num % i == 0)
                {
                    prime = false;
                }
            }
            return prime;
        }
        // public int UserNumber { get; set; }
        // private static List<Number> _instances = new List<Number> { };

        // public Number(int num)
        // {
        //     UserNumber = num;
        //     _instances.Add(this);
        // }

        // public static List<Number> GetAll()
        // {
        //     return _instances;
        // }

        // public static void ClearAll()
        // {
        //     _instances.Clear();
        // }
    }
}