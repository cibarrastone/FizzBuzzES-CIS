using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBussLib.Interface
{
    public interface ISuperFizzBuzz
    {
        /// <summary>
        /// Add new Token evaluation to our base program
        /// </summary>
        /// <param name="token">User specified token</param>
        /// <param name="evaluation">Evaluation predicate</param>
        public void AddNewToken(string token, Predicate<int> evaluation);

        /// <summary>
        /// New function to evaluate based on user provided ranges
        /// </summary>
        /// <param name="inputRanges">Start and End ranges</param>
        public List<Tuple<int, string>> GetEvaluationRanges(List<Tuple<int, int>> inputRanges);

    }
}
