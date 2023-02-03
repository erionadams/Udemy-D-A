// namespace SelectionSortAlgorithm
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<int> numbers = new List<int>{6, 5, 3, 8, 7, 2, 1, 4};
//             SelectionSort(numbers);
//         }

//         public static List<int> SelectionSort(List<int> numbers) //O(n^2)
//         {
//             int minNum = 0;
            
//             for(int i = 0; i < numbers.Count; i++)
//             {
//                 minNum = i;
//                 int temp = numbers[i];
//                 for(int j = i+1; j < numbers.Count; j++)
//                 {
//                     if(numbers[j] < numbers[minNum])
//                     {
//                         minNum = j;
//                     }
//                 }
//                 numbers[i] = numbers[minNum];
//                 numbers[minNum] = temp;
//             }

//             foreach(int i in numbers){
//                 Console.Write(i);
//             }

//             return numbers;
//         }
//     }
// }