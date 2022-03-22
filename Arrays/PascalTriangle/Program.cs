using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr = {1};
            Console.WriteLine(arr[0]);
            for (int i = 1; i < num; i++)
            {
                int[] newArr = new int[i+1];
                for (int j = 0; j < newArr.Length; j++)
                {
                    if (j==0 || j == newArr.Length-1)
                    {
                        newArr[j] = 1;

                    }
                    else
                    {
                        newArr[j] = arr[j - 1] + arr[j];
                    }
                }
                Console.WriteLine(string.Join(" ", newArr));
                arr = newArr;

            }
        }
    }
}
