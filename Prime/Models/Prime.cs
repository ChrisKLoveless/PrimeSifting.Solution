using System.Collections.Generic;

namespace Prime.Models
{
    public class Number 
    {
        public int UserNumber { get; set; }
        private static List<Number> _instances = new List<Number> { };

        public Number(int num)
        {
            UserNumber = num;
            _instances.Add(this);
        }

        public static List<Number> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}