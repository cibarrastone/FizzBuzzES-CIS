using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBussLib.Interface
{
    public interface IFizzBuzz
    {
        /// <summary>
        /// Retrieve the Token - Rules to be evaluated on the program
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, Predicate<int>> GetEvaluationDictionary();

        /// <summary>
        /// Main fizz buzz function to retrieve the whole number-token collection
        /// </summary>
        /// <param name="start">the start index number of the cycle</param>
        /// <param name="end">the finish line number for the program</param>
        /// <returns></returns>
        public List<Tuple<int, string>> GetRangeTokens(int start, int end);
    }
}
