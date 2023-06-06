using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProgramming
{
    internal class EvenAndOldArray
    {
        public int EvenOldArrayNumber(int n) {

            int[] arr = new int[n];
            int[] evenArr = new int[n];
            int[] oddArr = new int[n];

            Console.WriteLine($"Input {n} elements in the array:");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"element - {i} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int evenCount = 0;
            int oddCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArr[evenCount] = arr[i];
                    evenCount++;
                }
                else
                {
                    oddArr[oddCount] = arr[i];
                    oddCount++;
                }
            }

            Console.Write("The Even elements are: ");
            for (int i = 0; i < evenCount; i++)
            {
                Console.Write($"{evenArr[i]} ");
            }

            Console.Write("\nThe Odd elements are: ");
            for (int i = 0; i < oddCount; i++)
            {
                Console.Write($"{oddArr[i]} ");
            }

            return n;
        }
    }
}
