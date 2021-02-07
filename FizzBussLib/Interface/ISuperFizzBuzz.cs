using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBussLib.Interface
{
    public interface ISuperFizzBuzz
    {
        public void AddNewToken(string token, Predicate<int> evaluation);

    }
}
