// namespace InsertionSortAlgorithm
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<int> numbers = new List<int>{6, 5, 3, 1, 8, 7, 2, 4};
//             InsertionSort(numbers);
//         }

//         public static List<int> InsertionSort(List<int> numbers)
//         {
//             int key, j;

//             for(int i = 1; i < numbers.Count; i++)
//             {
//                 key = numbers[i];
//                 j = i - 1;
//                 while(j >= 0 && numbers[j] > key)
//                 {
//                     numbers[j+1] = numbers[j];
//                     j--;
//                 }
//                 numbers[j+1] = key;
//             }

//             foreach(int i in numbers)
//             {
//                 Console.Write(i + " ");
//             }

//             return numbers;
//         }
//     }
// }