using System;
using System.Collections.Generic;
using System.Linq;
using FizzBussLib.Interface;

namespace FizzBussLib
{
    public class FizzBuzz : IFizzBuzz
    {
        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        protected Dictionary<string, Predicate<int>> _evaluationDictionary;

        public FizzBuzz()
        {
            _evaluationDictionary = new Dictionary<string, Predicate<int>>
            {
                { "Fizz", i => ((i % 3) == 0) },
                { "Buzz", i => ((i % 5) == 0) }
            };
        }

        public Dictionary<string, Predicate<int>> GetEvaluationDictionary()
        {
            return _evaluationDictionary;
        }

        public List<Tuple<int, string>> GetRangeTokens(int start, int end)
        {
            if (end < start)
                throw new InvalidOperationException("The range established is invalid for the program to execute");
            var resTuples = new List<Tuple<int, string>>();
            for (var i = start; i <= end; i++)
            {
                foreach (var dicPage in _evaluationDictionary)
                {
                    if(dicPage.Value(i))
                        resTuples.Add(new Tuple<int, string>(i, dicPage.Key));
                }
                //If not criteria was found add the default state value with no tokens
                if(resTuples.FirstOrDefault(x => x.Item1==i)==null)
                    resTuples.Add(new Tuple<int, string>(i, null));
            }
            //Merged all matching number tokens

            var mergedTokens = resTuples.GroupBy(item => item.Item1)
                .Select(group => new
                {
                    item1 = group.Key,
                    //Make sure the item got at least one token
                    item2 = group.First().Item2 !=null ? string.Join("", group.SelectMany(x => x.Item2).ToList()) : null
                }).ToList();
            //Merging the anonymous grouping
            resTuples = (from tokens in mergedTokens
                select new Tuple<int, string>
                (
                    item1: tokens.item1,
                    item2: tokens.item2
                )).ToList();
            return resTuples;
        }
    }
}
