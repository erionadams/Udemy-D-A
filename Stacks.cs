using System;

namespace Stacks
{
    class Program
    {

        class StackNode
        {
            private string data;
            private StackNode next;

            public StackNode(string data)
            {
                this.data = data;
                this.next = null;
            }

            public string Data
            {
                get { return this.data; }
                set { this.data = value; }
            }

            public StackNode Next
            {
                get { return this.next; }
                set { this.next = value; }
            }
        }

        class Stack
        {
            private StackNode top;
            private StackNode bottom;
            private int size;

            public Stack()
            {
                this.top = null;
                this.bottom = this.top;
                this.size = 0;
            }

            public StackNode Peek()
            {
                if(this.top == null)
                {
                    Console.WriteLine("Stack is empty");
                    return null;
                }
                return this.top;
            }

            public void Push(string data)
            {
                StackNode newNode = new StackNode(data);
                newNode.Next = this.top;
                this.top = newNode;
                this.size++;
            }

            public void Pop()
            {
                StackNode del;

                if(this.top == null)
                {
                    Console.WriteLine("Stack is empty");
                    return;
                }
                del = this.top;
                this.top = del.Next;
                del = null;
                this.size--;
            }
        }

        //Array Implementation
        class StackArray
        {
            List<string> stackList;
            public StackArray()
            {
                stackList = new List<string>();
            }

            public string Peek()
            {
                return stackList[stackList.Count()-1];
            }

            public void Push(string data)
            {
                this.stackList.Add(data);
            }

            public void Pop()
            {
                this.stackList.Remove(stackList[stackList.Count()-1]);
            }

            public void Print()
            {
                for(int i = 0; i < stackList.Count(); i++)
                {
                    Console.WriteLine(stackList[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            Stack stack = new Stack();


            // stack.Push("Discord");
            // stack.Push("Facebook");
            // stack.Push("Udemy");
            // stack.Pop();
            // stack.Pop();

            // StackNode head = stack.Peek();

            // while(head != null)
            // {
            //     Console.WriteLine(head.Data);
            //     head = head.Next;
            // }


            //Array Implemantation
            StackArray stackA = new StackArray();

            stackA.Push("Instagram");
            stackA.Push("Udemy");
            stackA.Push("CoolMathGames");
            stackA.Pop();
            Console.WriteLine(stackA.Peek());

            stackA.Print();

            
        }
    }
}