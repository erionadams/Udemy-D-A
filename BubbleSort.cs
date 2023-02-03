// namespace BubbleSortAlgorithm
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<int> numbers = new List<int>{6, 5, 3, 1, 8, 7, 2, 4};
//             foreach(int i in numbers)
//             {
//                 Console.Write(i);
//             }
//             Console.WriteLine("\n");
//             BubbleSort(numbers);
//         }

//         public static List<int> BubbleSort(List<int> numbers)
//         {
//             for(int i = 0; i < numbers.Count; i++)
//             {
//                 for(int j = 0; j < numbers.Count - 1; j++)
//                 {
//                     if(numbers[j] > numbers[j+1])
//                     {
//                         int temp = numbers[j];
//                         numbers[j] = numbers[j+1];
//                         numbers[j+1] = temp;
//                     }
//                 }
//             }
//             foreach(int i in numbers)
//             {
//                 Console.Write(i);
//             }
//             return numbers;
//         }
//     }
// }