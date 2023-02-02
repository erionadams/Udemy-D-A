// // Given a number N, return the index value of the Fibonacci sequence,
// // where the sequence is:

// // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 ...
// // The pattern of the sequence is that each value is the sum of the 2 previous
// // values, that means that for N=5 -> 2+3

// namespace FibonacciSequence
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine(FibonacciRecursive(10));
//             Console.WriteLine(FibonacciIterative(8));
//         }

//         public static int FibonacciRecursive(int n) //O(2^n)
//         {
//             if(n < 2)
//             {
//                 return n;
//             }

//             return FibonacciRecursive(n-1) + FibonacciRecursive(n-2);
//         }

//         public static int FibonacciIterative(int n)
//         {
//             List<int> sequence = new List<int>{0, 1};

//             for(int i = 2; i < n + 1; i++)
//             {
//                 sequence.Add(sequence[i-2] + sequence[i-1]);
//             }
//             return sequence[n];
//         }
//     }
// }