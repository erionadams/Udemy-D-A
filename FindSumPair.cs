// using System;

// namespace FindSumPair
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] numbers1 = {1, 2, 3, 9};
//             int[] numbers2 = {1, 2, 4, 4};
//             int[] numbers3 = {6, 4, 3, 2, 1, 7};

//             Console.WriteLine(FindSumPair1(numbers2, 8));
//             Console.WriteLine(FindSumPair2(numbers1, 8));
//         }

//         //Naive - O(n^2)
//         public static bool FindSumPair1(int[] arr, int sumTarget)
//         {
//             for (int i = 0; i < arr.Length - 1; i++)
//             {
//                 for (int j = i + 1; j < arr.Length; j++)
//                 {
//                     if (arr[i] + arr[j] == sumTarget)
//                     {
//                         return true;
//                     }
//                 }
//             }
//             return false;
//         }

//         //Better - O(n)
//         public static bool FindSumPair2(int[] arr, int sum)
//         {
//             List<int> seenNumbers = new List<int>();
//              for(int i = 0; i < arr.Length; i++)
//              {
//                 if(seenNumbers.Contains(arr[i]))
//                 {
//                     return true;
//                 }
//                 seenNumbers.Add(sum - arr[i]);
//              }
//              return false;
//         }
//     }
// }