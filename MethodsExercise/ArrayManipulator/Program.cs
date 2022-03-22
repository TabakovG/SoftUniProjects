using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commArr = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (commArr[0])
                {
                    case "exchange":
                        int splitIndex = int.Parse(commArr[1]);
                        if (splitIndex > arr.Length - 1 || splitIndex < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            Exchange(arr, splitIndex);                            
                        }
                        break;
                    case "max":
                        int tryGetMaxValueIndex = GetMax(arr, commArr[1]);
                        if (tryGetMaxValueIndex == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(tryGetMaxValueIndex);
                        }
                        break;
                    case "min":
                        int tryGetMinValueIndex = GetMin(arr, commArr[1]);
                        if (tryGetMinValueIndex == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(tryGetMinValueIndex);
                        }
                        break;
                    case "first":
                    case "last":
                        if (int.Parse(commArr[1]) > arr.Length )
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            int[] resultArr = SelectElements(arr, commArr[0], int.Parse(commArr[1]), commArr[2]);
                            Console.WriteLine($"[{string.Join(", ", resultArr)}]");
                        }
                        break;
                    case "end":
                        return;
                }

            }
            Console.WriteLine($"[{string.Join(", ", arr)}]");

        }
        static int[] Exchange(int[] arr, int index)
        {

            for (int repeat = 0; repeat <= index; repeat++)
            {
                int firstNum = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = firstNum;
            }

            return arr;
        }
        static int GetMax(int[] array, string type)
        {
            int maxEven = int.MinValue;
            int maxOdd = int.MinValue;
            int maxEvenIndex = -1;
            int maxOddIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= maxEven && array[i] % 2 == 0)
                {
                    maxEven = array[i];
                    maxEvenIndex = i;
                }
                else if (array[i] >= maxOdd && array[i] % 2 != 0)
                {
                    maxOdd = array[i];
                    maxOddIndex = i;

                }
            }
            if (type == "even")
            {
                return maxEvenIndex;
            }
            else
            {
                return maxOddIndex;
            }
        }
        static int GetMin(int[] array, string type)
        {
            int minEven = int.MaxValue;
            int minOdd = int.MaxValue;
            int minEvenIndex = -1;
            int minOddIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= minEven && array[i] % 2 == 0)
                {
                    minEven = array[i];
                    minEvenIndex = i;
                }
                else if (array[i] <= minOdd && array[i] % 2 != 0)
                {
                    minOdd = array[i];
                    minOddIndex = i;

                }
            }
            if (type == "even")
            {
                return minEvenIndex;
            }
            else
            {
                return minOddIndex;
            }
        }
        static int[] SelectElements(int[] array, string position, int count, string type)
        {
            string evenDigits= string.Empty;
            string oddDigits = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2 == 0)
                {
                    evenDigits+= array[i] + " ";
                }
                else
                {
                    oddDigits += array[i] + " ";

                }
            }
            int[] evenArray = evenDigits.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] oddArray = oddDigits.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] selectedArray = new int[0];
            if (type == "odd")
            {
                selectedArray = oddArray;
            }
            else
            {
                selectedArray = evenArray;

            }
            int returnedElementsCount = (count < selectedArray.Length ? count : selectedArray.Length);
            int[] outputArray = new int[returnedElementsCount];
            if (position == "last")
            {
                Array.Reverse(selectedArray);
            }

            for (int i = 0; i < returnedElementsCount; i++)
            {
                outputArray[i] = selectedArray[i];
            }
            if (position == "last")
            {
                Array.Reverse(outputArray);
            }
            return outputArray;

        }

    }
}
