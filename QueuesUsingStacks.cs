// namespace QueuesUsingStacks
// {
//     class Program
//     {
//         class MyQueue
//         {
//             private Stack<int> stack1;
//             private Stack<int> stack2;

//             public MyQueue()
//             {
//                 stack1 = new Stack<int>();
//                 stack2 = new Stack<int>();
//             }

//             public void Push(int x)
//             {
//                 stack1.Push(x);
//             }

//             public int Pop()
//             {
//                 if(Empty())
//                 {
//                     return Int32.MinValue;
//                 }

//                 while(stack1.Count > 0)
//                 {
//                     stack2.Push(stack1.Pop());
//                 }
//                 int popItem = stack2.Pop();
                
//                 while(stack2.Count > 0)
//                 {
//                     stack1.Push(stack2.Pop());
//                 }

//                 return popItem;
//             }

//             public int Peek()
//             {
//                 if(Empty())
//                 {
//                     return Int32.MinValue;
//                 }

//                 while(stack1.Count > 0)
//                 {
//                     stack2.Push(stack1.Pop());
//                 }

//                 int peek = stack2.Peek();

//                 while(stack2.Count > 0)
//                 {
//                     stack1.Push(stack2.Pop());
//                 }

//                 return peek;
//             }

//             public bool Empty()
//             {
//                 if(stack1.Count == 0 && stack2.Count == 0)
//                 {
//                     return true;
//                 }
//                 return false;
//             }
//         }

//         static void Main(string[] args)
//         {
//             MyQueue newQ = new MyQueue();

//             newQ.Push(4);
//             newQ.Push(6);
//             newQ.Pop();
//             newQ.Pop();

//             if(!newQ.Empty()) { Console.WriteLine(newQ.Peek()); }
//             Console.WriteLine(newQ.Empty());
//         }
//     }
// }