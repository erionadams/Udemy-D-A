// using System.Collections;

// namespace FirstReccurring
// {
//     class MainClass
//     {
//         static void Main(string[] args)
//         {
//             int[] numberArray = {2, 4, 6, 5, 3};
//             Console.WriteLine(FirstReccurringCharacter1(numberArray));
//         }

//         //O(n)
//         public static dynamic FirstReccurringCharacter1(int[] array1)
//         {
//             Hashtable countOccurrences = new Hashtable(); //With a space complexity of O(n). Worst case this program will have to remember the whole input array.

//             for (int i = 0; i < array1.Length; i++)
//             {
//                 if(countOccurrences.ContainsKey(array1[i]))
//                 {
//                     return array1[i];
//                 }
//                 else
//                 {
//                     countOccurrences.Add(array1[i], 1);
//                 }
//             }

//             return "undefined";
//         }
//     }
// }