
// namespace LinkedLists
// {
//     class Program
//     {
//         class LinkedListNode
//         {
//             private dynamic data;
//             private LinkedListNode next;

//             public LinkedListNode(int x)
//             {
//                 this.data = x;
//                 this.next = null;
//             }

//             public int Data
//             {
//                 get { return this.data; }
//                 set { this.data = value; }
//             }

//             public LinkedListNode Next
//             {
//                 get { return this.next; }
//                 set { this.next = value; }
//             }
//         }

//         class LinkedList
//         {
//             private LinkedListNode head;
//             private LinkedListNode tail;
//             private int size;

//             public LinkedList()
//             {
//                 this.head = null;
//                 this.tail = this.head;
//                 this.size = 0;

//             }

//             public bool Empty
//             {
//                 get { return this.size == 0; }
//             }

//             public int Count
//             {
//                 get { return this.size; }
//             }

//             public void Append(int data) //O(1)
//             {
//                 //crete a new node that holds the new data and points to null.
//                 LinkedListNode newNode = new LinkedListNode(data);

//                 //If the list is empty set the new data as the head.
//                 if(this.size == 0)
//                 {
//                     this.head = newNode;
//                 }
//                 //Else there is already data in the list.
//                 //Point the last node's pointer to the new data.
//                 //Set the new node.next to null (new tail).
//                 else
//                 {
//                     this.tail.Next = newNode;
//                 }
//                 this.tail = newNode;
//                 this.size++;
//             }

//             public void Prepend(int data) //O(1)
//             {
//                 if(head != null)
//                 {
//                     LinkedListNode newNode = new LinkedListNode(data);
//                     newNode.Next = this.head;
//                     this.head = newNode;
//                     this.size++;
//                 }
//             }
            
//             public void Insert(int data, int index) //O(n) sometimes 0(1)
//             {
//                 LinkedListNode pre = this.head;
//                 LinkedListNode aft;

//                 if(index == this.size)
//                 {
//                     this.Append(data);
//                     return;
//                 }
//                 else if(index == 0)
//                 {
//                     this.Prepend(data);
//                     return;
//                 }
//                 else if(index > this.size)
//                 {
//                     Console.WriteLine("Input Error");
//                     return;
//                 }

//                 if(head != null)
//                 {
//                     for(int i = 0; i < index - 1; i++)
//                     {
//                         pre = pre.Next;
//                     }

//                     aft = pre.Next;
//                     LinkedListNode newNode = new LinkedListNode(data);
//                     newNode.Next = aft;
//                     pre.Next = newNode;
//                     this.size++;
//                 }
//                 return;
//             }

//             public void Remove(int index) //O(n)
//             {
//                 LinkedListNode pre = this.head;
//                 LinkedListNode del;
//                 LinkedListNode aft;

//                 if(this.head == null)
//                 {
//                     Console.WriteLine("The list is empty");
//                     return;
//                 }
//                 else if(this.head != null && index > this.size - 1 || index < 0)
//                 {
//                     Console.WriteLine("Index error");
//                     return;
//                 }

//                 for(int i = 0; i < index - 1; i++)
//                 {  
//                     pre = pre.Next;
//                 }
//                 del = pre.Next;
//                 aft = del.Next;
//                 pre.Next = aft;
//                 del = null;
//                 this.size--;
//             }

//             public LinkedListNode FindHead()
//             {
//                 return this.head;
//             }

//         }

//         static void Main(string[] args)
//         {
//             LinkedList list = new LinkedList();

//             list.Append(5);
//             list.Append(58);
//             list.Append(73);
//             //list.Prepend(1);
//             //list.Prepend(7);
//             list.Append(32);

//             list.Remove(-3);

//             //list.Insert(0, 6);



//             LinkedListNode head = list.FindHead();


//             while(head != null)
//             {
//                 Console.WriteLine(head.Data);
//                 head = head.Next;
//             }

//             Console.WriteLine("count: " + list.Count);

//         }
//     }
// }