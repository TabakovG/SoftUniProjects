using System;
using System.Collections.Generic;
using System.Text;

namespace Phones
{
    public class StationaryPhone : IPhonable
    {
        public string Call(string number)
        {
            if (IsValid(number))
            {
                return $"Dialing... {number}";
            }
            return "Invalid number!";
        }

        private bool IsValid(string number)
        {
            foreach (char ch in number)
            {
                if (!char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
