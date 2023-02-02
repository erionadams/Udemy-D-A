// namespace Graphs
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
//         }
//         class Graph
//         {
//             private int numberOfNodes;
//             private Dictionary<int, LinkedList> adjList;

//             public Graph()
//             {
//                 this.adjList = new Dictionary<int, LinkedList>();
//                 this.numberOfNodes = 0;
//             }

//             public void AddEdge(int node1, int node2)
//             {
//                 if(adjList.ContainsKey(node1) && adjList.ContainsKey(node2))
//                 {
//                     this.adjList[node1].Prepend(node2);
//                     this.adjList[node2].Prepend(node1);
//                 }
//                 else
//                 {
//                     Console.WriteLine("Vertex does not exsist");
//                     return;
//                 }
//             }
//             public void AddVertex(int node)
//             {
//                 LinkedList emptyLL = new LinkedList();
//                 adjList.Add(node, emptyLL);
//                 this.numberOfNodes++;
//             }
//         }

//         static void Main(string[] args)
//         {
//             Graph graph = new Graph();
//             graph.AddVertex(1);
//             graph.AddVertex(13);
//             graph.AddVertex(3);
//             graph.AddVertex(5);
//             graph.AddVertex(6);
//             graph.AddVertex(8);
//             graph.AddEdge(1, 13);
//             graph.AddEdge(1, 5);
//             graph.AddEdge(5, 8);
//         }
//     }
// }