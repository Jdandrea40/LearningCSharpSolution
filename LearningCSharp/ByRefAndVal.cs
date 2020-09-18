using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class ByRefAndVal
    {
        [Fact]
        public void ShowingIt()
        {
            int x = 10, y = 20;
            MessWithThem(ref x, ref y);
            Assert.Equal(20, x);
            Assert.Equal(40, y);

        }
        [Fact]
        public void UsingOutParam()
        {
            // out allows you to not have a pre initialized variable
            var fullName = FormatName("Luke", "Skywalker", out int x);
            Assert.Equal("Skywalker, Luke", fullName);
            Assert.Equal(15, x);
        }
        [Fact]
        public void SwappingThings()
        {
            int x = 1, y = 2;

            Swap(ref x, ref y);
            Assert.Equal(2, x);
            Assert.Equal(1, y);
        }

        private void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public void MessWithThem(ref int a, ref int b)
        {
            a = a * 2;
            b = b * 2;
        }

        public string FormatName(string first, string last, out int count)
        {
            var fullName = $"{last}, {first}";
            count = fullName.Length;
            return fullName;
        }
    }
}
