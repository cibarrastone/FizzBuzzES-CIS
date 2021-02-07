using FizzBussLib;
using FizzBussLib.Interface;
using System;
using System.Collections.Generic;

namespace SuperFizzBuzzES_CIS
{
    class Program
    {
        static void Main(string[] args)
        {
            //We could inject this with DI Containers
            ISuperFizzBuzz fizzBuzzObj = new SupperFizzBuzz();
            // ReSharper disable once CommentTypo
            /*
             * The requirement page do not specify the way on how the inputs of the client going to be addressed,
             * this could be a GUI input or an appconfig.json parameter its ambiguous at this point
            */
            /*
             The problem definition in the point 1 of super fizz buzz states that multiple range of numbers
             may be supplied not necessary sequentially, so multiple ranges can be supplied
             */
            var ranges = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(12, 145),
                new Tuple<int, int>(45, 70)
            };
            //Adding new rules before retrieving the values
            fizzBuzzObj.AddNewToken("Bazz", i => ((i % 38) == 0));
            var tokens = fizzBuzzObj.GetEvaluationRanges(ranges);
            foreach (var item in tokens)
            {
                //The tuple item2 stands for the token if apply if not then the function didn't found a token criteria for that number
                Console.WriteLine(item.Item2 ?? item.Item1.ToString());
            }
        }
    }
}
