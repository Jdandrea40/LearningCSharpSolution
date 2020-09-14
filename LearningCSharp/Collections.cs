using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class Collections
    {
        [Fact]
        public void MyFavoriteNumbers()
        {
            var myFavoriteNumbers = new ArrayList();
            myFavoriteNumbers.Add(8);
            myFavoriteNumbers.Add(20);
            myFavoriteNumbers.Add(108);

            Assert.Equal(8, myFavoriteNumbers[0]);
            myFavoriteNumbers[1] = 22;
            Assert.Equal(22, myFavoriteNumbers[1]);

            myFavoriteNumbers.Add("Tacos");
            // myFavoriteNumbers[0] = "Cheerios";

            var firstTwo = ((int)myFavoriteNumbers[0]) +
                ((int)myFavoriteNumbers[1]);
            Assert.Equal(30, firstTwo);

        }

        [Fact]
        public void GenericFavoriteNumbers()
        {
            var myFavoriteNumbers = new List<int>();
            // "Parametric Polymorphism"
            myFavoriteNumbers.Add(8);
            myFavoriteNumbers.Add(20);
            myFavoriteNumbers.Add(100);

            var firstTwo = myFavoriteNumbers[0] + myFavoriteNumbers[1];
            Assert.Equal(28, firstTwo);
        }

        [Fact]
        public void InitializingAList()
        {
            var myFavoriteFoods = new List<string> { "Tacos", "Beer", "Pizza" };
            Assert.Equal("Beer", myFavoriteFoods[1]);

        }
        [Fact]
        public void EnumeratingTheValuesOfAList()
        {
            var nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var total = 0; // NOTE: There are better ways to sum up things.

            foreach (var number in nums)
            {
                total += number;
            }

            Assert.Equal(45, total);
            Assert.Equal(45, nums.Sum()); // just putting this here so you
            /// don't think I'm dumb and don't know it. I wanted to show
            /// foreach though. don't judge.
        }

        [Fact]
        public void UsingADictionary()
        {
            var friends = new Dictionary<char, string>
            {
                { 's', "Sean" },
                { 'j', "Jessika" }
            };

            friends.Add('d', "David");

            Assert.Equal("Sean", friends['s']);
            Assert.True(friends.ContainsKey('d'));
            Assert.False(friends.ContainsKey('x'));


            // Enumerating the keys
            foreach(char key in friends.Keys)
            {
                // 's', 'j', 'd'
            }

            // Enumerating the Values
            foreach(string value in friends.Values)
            {
                // "Sean", "Jessika", "David"
            }

            foreach(KeyValuePair<char, string> kvp in friends)
            {
                //kvp.Key == 'S';
                // kvp.Value == "Sean";, etc.e tc.
            }

        }
    }
}
