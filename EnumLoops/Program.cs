using System;

namespace EnumLoops
{
    public enum MonthOfYear
    {
        January, February, March,
        April, May, June,
        July, August, September,
        October, November, December
    }
    class Program
    {
        static void Main(string[] args)
        {

            foreach (MonthOfYear item in typeof(MonthOfYear).GetEnumValues()) 
            {
                Console.WriteLine(item);
            }

            foreach (var item in Enum.GetValues(typeof(MonthOfYear))) 
            {
                Console.WriteLine(item);
            }

            foreach (var item in Enum.GetNames(typeof(MonthOfYear))) { }
        }
    }
}
