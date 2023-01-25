// using System.Text;

// namespace ReverseStringProgram
// {
//     class Reverse
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine(ReverseString1("Erion"));
//             Console.WriteLine(ReverseString2("Erion"));
//         }

//         //O(n)
//         public static StringBuilder ReverseString1(string str)
//         {
//             StringBuilder inputError = new StringBuilder("Input Error");

//             if(str.Length < 2 || str.GetType() != typeof(string)){
//                 return inputError;
//             }
//             StringBuilder reversedString = new StringBuilder();
//             for(int i = str.Length - 1; i > 0 - 1; i--){
//                 reversedString.Append(str[i]);
//             }

//             return reversedString;
//         }

//         public static string ReverseString2(string str){
//             char[] reversedStr = str.ToCharArray();
//             Array.Reverse(reversedStr);
//             return new string(reversedStr);
//         }
//     }
// }