using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FizzBussLib.Interface;

namespace FizzBussLib
{
    public class SupperFizzBuzz : FizzBuzz, ISuperFizzBuzz
    {
        public void AddNewToken(string token, Predicate<int> evaluation)
        {
            _evaluationDictionary.Add(token, evaluation);
        }

        public List<Tuple<int, string>> GetEvaluationRanges(List<Tuple<int, int>> inputRanges)
        {
            List<Tuple<int, string>> resTuples = new List<Tuple<int, string>>();
            //Overwrite the behaviour of the predicates for base FizzBuzz Class
            _evaluationDictionary.Remove(_evaluationDictionary.First(x => x.Key.Equals("Buzz")).Key);
            _evaluationDictionary.Add("Buzz", i => ((i % 7) == 0));
            foreach (var ranges in inputRanges)
            {
                resTuples.AddRange(GetRangeTokens(ranges.Item1, ranges.Item2));
            }

            return resTuples;
        }
    }
}
