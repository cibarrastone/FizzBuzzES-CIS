using FizzBussLib.Interface;
using FizzBussLib;
using System;

namespace FizzBuzzES_CIS
{
    class Program
    {
        static void Main(string[] args)
        {
            //We could inject this with DI Containers
            IFizzBuzz fizzBuzzObj = new FizzBuzz();
            // ReSharper disable once CommentTypo
            /*
             * The requirement page do not specify the way on how the inputs of the client going to be addressed,
             * this could be a GUI input or an appconfig.json parameter its ambiguous at this point
            */
            var tokens = fizzBuzzObj.GetRangeTokens(1, 100);
            foreach (var item in tokens)
            {
                //The tuple item2 stands for the token if apply if not then the function didn't found a token criteria for that number
                Console.WriteLine(item.Item2 ?? item.Item1.ToString());
            }
            
        }
    }
}
