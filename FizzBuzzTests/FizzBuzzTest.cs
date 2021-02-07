using System;
using System.Collections.Generic;
using FizzBussLib;
using FizzBussLib.Interface;
using NUnit.Framework;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzTest
    {
        private IFizzBuzz _iFizzBuzzObj;
        private Dictionary<string, Predicate<int>> _evaluationDictionary;
        private Tuple<int, int> _range;

        [SetUp]
        public void Setup()
        {
            //All related tasks to test initialization goes here DI Inject, variables setups and Moq extensions
            _iFizzBuzzObj = new FizzBuzz();
            //We can play with the established problem criteria to move the matching of the test and assert re-actively 
            _evaluationDictionary = new Dictionary<string, Predicate<int>>
            {
                { "Fizz", i => ((i % 3) == 0) },
                { "Buzz", i => ((i % 5) == 0) }
                //This would failed to assert because is not the base criteria
                //{ "Buzz", i => ((i % 6) == 0) }
            };
            _range = new Tuple<int, int>(1, 100);
            //Invalid range assertion
            //_range = new Tuple<int, int>(45, 1);
        }

        [Test]
        public void TestClassNumberRanges()
        {
            //Invalid range exception
            _range = new Tuple<int, int>(45, 1);
            var resultTokens = _iFizzBuzzObj.GetRangeTokens(_range.Item1, _range.Item2);
            Assert.IsTrue(resultTokens!=null);
        }

        [Test]
        public void TestGetEvaluationDictionary()
        {
            //The behaviour of the default dictionary should contain the 2 defined program values
            Assert.IsTrue(_iFizzBuzzObj.GetEvaluationDictionary().Count>0);
        }

        [Test]
        public void TestTokensResult()
        {
            var resultTokens = _iFizzBuzzObj.GetRangeTokens(_range.Item1, _range.Item2);
            foreach (var token in resultTokens)
            {
                foreach (var tokenCondition in _evaluationDictionary)
                {
                    if ((tokenCondition.Value(token.Item1)) && !token.Item2.Contains(tokenCondition.Key)) { 
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
