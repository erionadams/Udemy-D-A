// using System.Linq;

// namespace MergeArrays
// {
    
//     class MergeSortedArrays
//     {

//         static void Main(string[] arg)
//         {
//             int[] arr1 = {0,3,4,31};
//             int[] arr2 = {4,6,30};
//             MergeSortedArrays1(arr1, arr2);
//         }

//         public static Array MergeSortedArrays1(int[] arr1, int[] arr2)
//         {
//             int[] firstArrCopy = new int[arr1.Length];
//             int[] joinedArray = new int[arr1.Length + arr2.Length];
//             int firstArrIndex = 0;


//             if(arr1.GetType() != typeof(int[]) || arr2.GetType() != typeof(int[]) || arr1.Length < 0 || arr2.Length < 0)
//             {
//                 Console.WriteLine("Input Error");
//             }


//             arr1.CopyTo(firstArrCopy, 0); //0(n)

//             for(int j = 0; j < arr2.Length; j++)
//             {
//                 if(arr2[j] > firstArrCopy[firstArrIndex])
//                 {
//                     joinedArray = arr1.Concat(new int[] {arr2[j]}).ToArray();
//                 }
                
                
//             }
//             for(int k = 0; k < joinedArray.Length; k++)
//             {
//                 Console.WriteLine(joinedArray[k]);

//             }
//             return arr1;
//         }
//     }
// }