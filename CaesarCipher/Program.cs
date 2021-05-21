using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: ");
            string input = Console.ReadLine();
            Console.WriteLine("Key: ");
            int key = int.Parse(Console.ReadLine());
            char[] arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 65 && arr[i] <= 90)
                {
                    arr[i] += (char)key;
                    if (arr[i] > 90)
                    {
                        arr[i] %= (char)90;
                        arr[i] += (char)64;
                    }
                }
                else if (arr[i] >= 97 && arr[i] <= 122)
                {
                    arr[i] += (char)key;
                    if (arr[i] > 122)
                    {
                        arr[i] %= (char)122;
                        arr[i] += (char)96;
                    }
                }
                Console.Write(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
