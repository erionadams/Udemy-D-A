// namespace DoublyLinkedLists
// {
//     class Program
//     {
//         class DoublyLinkedListNode
//         {
//             private dynamic data;
//             private DoublyLinkedListNode next;
//             private DoublyLinkedListNode prev;

//             public DoublyLinkedListNode(int x)
//             {
//                 this.data = x;
//                 this.next = null;
//                 this.prev = null;
//             }

//             public int Data
//             {
//                 get { return this.data; }
//                 set { this.data = value; }
//             }

//             public DoublyLinkedListNode Next
//             {
//                 get { return this.next; }
//                 set { this.next = value; }
//             }

//             public DoublyLinkedListNode Prev
//             {
//                 get { return this.prev; }
//                 set { this.prev = value; }
//             }
//         }

//         class DoublyLinkedList
//         {
//             private DoublyLinkedListNode head;
//             private DoublyLinkedListNode tail;
//             private int size;

//             public DoublyLinkedList()
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
//                 DoublyLinkedListNode newNode = new DoublyLinkedListNode(data);

//                 //If the list is empty set the new data as the head.
//                 if(this.size == 0)
//                 {
//                     this.head = newNode;
//                     this.tail = this.head;
//                 }
//                 //Else there is already data in the list.
//                 //Point the last node's pointer to the new data.
//                 //Set the new node.next to null (new tail).
//                 else
//                 {
//                     newNode.Prev = this.tail;
//                     this.tail.Next = newNode;
//                 }
//                 this.tail = newNode;
//                 this.size++;
//             }

//             public DoublyLinkedListNode FindHead()
//             {
//                 return this.head;
//             }
//         }

//         static void Main(string[] args)
//         {
//             DoublyLinkedList list = new DoublyLinkedList();

//             list.Append(5);
//             list.Append(58);
//             list.Append(73);
//             list.Append(32);


//             DoublyLinkedListNode head = list.FindHead();


//             while(head != null)
//             {
//                 Console.WriteLine(head.Data);
//                 head = head.Next;
//             }

//             Console.WriteLine("count: " + list.Count);

//         }
//     }
// }