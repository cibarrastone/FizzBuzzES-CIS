using System;
using System.Collections.Generic;
using System.Text;
using FizzBussLib;
using FizzBussLib.Interface;
using NUnit.Framework;
// ReSharper disable StringLiteralTypo

namespace FizzBuzzTests
{
    [TestFixture]
    public class SuperFizzBuzzTest
    {
        private SupperFizzBuzz _superFizzBuzzObj;
        private Dictionary<string, Predicate<int>> _evaluationDictionary;
        private List<Tuple<int, int>> _ranges;

        [SetUp]
        public void Setup()
        {
            _superFizzBuzzObj = new SupperFizzBuzz();
            //We can play with the established problem criteria to move the matching of the test and assert re-actively 
            _evaluationDictionary = new Dictionary<string, Predicate<int>>
            {
                { "Fizz", i => ((i % 3) == 0) },
                { "Buzz", i => ((i % 7) == 0) },
                { "Bazz", i => ((i % 38) == 0) },
                { "Frog", i => ((i % 4) == 0) },
                { "Duck", i => ((i % 13) == 0) },
                { "Chicken", i => ((i % 9) == 0) },
                //This would failed to assert because is not the base criteria
                //{ "Buzz", i => ((i % 6) == 0) }
            };
            _ranges = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(12, 145),
                new Tuple<int, int>(45, 70)
            };
            //Adding new rules before retrieving the values
            _superFizzBuzzObj.AddNewToken("Bazz", i => ((i % 38) == 0));
            _superFizzBuzzObj.AddNewToken("Frog", i => ((i % 4) == 0));
            _superFizzBuzzObj.AddNewToken("Duck", i => ((i % 13) == 0));
            _superFizzBuzzObj.AddNewToken("Chicken", i => ((i % 9) == 0));
            //Invalid range assertion
            //_range = new Tuple<int, int>(45, 1);
        }

        [Test]
        public void TestAddToken()
        {
            _superFizzBuzzObj.AddNewToken("CustomValue", i => ((i % 39) == 0));
            var dictionary = _superFizzBuzzObj.GetEvaluationDictionary();
            Assert.IsTrue(dictionary.ContainsKey("CustomValue"));
        }

        [Test]
        public void TestGetEvaluationRanges()
        {
            var resultTokens = _superFizzBuzzObj.GetEvaluationRanges(_ranges);
            foreach (var token in resultTokens)
            {
                //This console its to see the scenario for SuperFizzBuzz point 1
                Console.WriteLine(token.Item2 ?? token.Item1.ToString());
                foreach (var tokenCondition in _evaluationDictionary)
                {
                    if ((tokenCondition.Value(token.Item1)) && !token.Item2.Contains(tokenCondition.Key))
                    {
                        Assert.Warn($"Invalid token assertion for number {token.Item1.ToString()} and token {tokenCondition.Key}");
                        Assert.Fail();
                        return; 
                    }
                }
            }
            Assert.IsTrue(true);
        }
    }
}
