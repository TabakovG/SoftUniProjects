using System;
using System.Collections.Generic;

namespace GenericSwapMethod
{
    internal class StartUp
    {
        static void Main()
        {
            
        }

        public void GenericMethod<T>(List<T> inputArray, int indexOne, int indexTwo) 
        {
            if (indexOne < 0 || indexOne >inputArray.Count-1 || indexTwo < 0 || indexTwo > inputArray.Count-1)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                var element = inputArray[indexOne];
                inputArray[indexOne] = inputArray[indexTwo];
                inputArray[indexTwo] = element;
            }
        }
    }
}
