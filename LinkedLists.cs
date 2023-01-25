
namespace LinkedLists
{
    class Program
    {
        class LinkedListNode
        {
            private dynamic data;
            private LinkedListNode next;

            public LinkedListNode(int x)
            {
                this.data = x;
                this.next = null;
            }

            public int Data
            {
                get { return this.data; }
                set { this.data = value; }
            }

            public LinkedListNode Next
            {
                get { return this.next; }
                set { this.next = value; }
            }
        }

        class LinkedList
        {
            private LinkedListNode head;
            private LinkedListNode tail;
            private int size;

            public LinkedList()
            {
                this.head = null;
                this.tail = null;
                this.size = 0;

            }

            public bool Empty
            {
                get { return this.size == 0; }
            }

            public int Count
            {
                get { return this.size; }
            }

            public void Append(int data) //O(1)
            {
                //crete a new node that holds the new data and points to null.
                LinkedListNode newNode = new LinkedListNode(data);

                //If the list is empty set the new data as the head.
                if(this.size == 0)
                {
                    this.head = newNode;
                }
                //Else there is already data in the list.
                //Point the last node's pointer to the new data.
                //Set the new node.next to null (new tail).
                else
                {
                    this.tail.Next = newNode;
                }
                this.tail = newNode;
                this.size++;
            }

            public void Prepend(int data) //O(1)
            {
                if(head != null)
                {
                    LinkedListNode newNode = new LinkedListNode(data);
                    newNode.Next = this.head;
                    this.head = newNode;
                    this.size++;
                }
            }

            public LinkedListNode FindHead()
            {
                return this.head;
            }

            // public LinkedListNode FindLastNode()
            // {
            //     LinkedListNode node = this.head;
            //     while (node.Next != null)
            //     {
            //         node = node.Next;
            //         Console.WriteLine(node.Data);
            //     }
                
            //     return node;
            // }
        }

        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.Append(5);
            list.Append(16);
            list.Prepend(1);
            list.Prepend(7);
            list.Append(10);

            // order should be: 7, 1, 5, 16, 10

            LinkedListNode head = list.FindHead();


            while(head != null)
            {
                Console.WriteLine(head.Data);
                head = head.Next;
            }

            Console.WriteLine("count: " + list.Count);

        }
    }
}