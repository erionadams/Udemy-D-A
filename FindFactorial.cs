// namespace FindFactorial
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine(FindFactorialRecurive(7));
//             Console.WriteLine(FindFactorialIterative(5));
//         }

//         public static int FindFactorialRecurive(int x)
//         {
//             if(x == 2)
//             {
//                 return 2;
//             }
//             return x * FindFactorialRecurive(x - 1);

//         }

//         public static int FindFactorialIterative(int x)
//         {
//             int answer = 1;
//             for(int i = 2; i <= x; i++)
//             {
//                 answer = answer * i;
//             }

//             return answer;
//         }
//     }
// }