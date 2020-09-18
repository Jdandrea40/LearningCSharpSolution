using System;
using System.Linq;

namespace LearningCSharp
{
    public class Thingy
    {
        public string FormatName(string first, string last)
        {
            return $"{last}, {first}";
        }

        public string FormatName(string first, string last, string mi)
        {
            return FormatName(first, last) + $" {mi}.";
        }

        public int Add(int a=5, int b=10)
        {
            return a + b;
        }
        /// <summary>
        /// params allows (1, 2, 4) as well as nums[] to be passed to it
        /// 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int Add(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}