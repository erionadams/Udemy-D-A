// using System.Collections;

// namespace BFS_DFS
// {
//     class Program
//     {
//         class BSTNode
//         {
//             private int value;
//             private BSTNode right;
//             private BSTNode left;

//             public BSTNode(int x)
//             {
//                 this.value = x;
//                 this.right = null;
//                 this.left = null;
//             }

//             public int Value
//             {
//                 get { return this.value; }
//                 set { this.value = value; }
//             }

//             public BSTNode Right
//             {
//                 get { return this.right; }
//                 set { this.right = value; }
//             }

//             public BSTNode Left
//             {
//                 get { return this.left; }
//                 set { this.left = value; }
//             }
//         }

//         class BST
//         {
//             private BSTNode root;
//             private int size;

//             public BST()
//             {
//                 this.root = null;
//                 this.size = 0;
//             }

//             public void Insert(int x)
//             {
//                 BSTNode newNode = new BSTNode(x);
//                 BSTNode selectedNode = this.root;
//                 BSTNode locParent;

//                 if(Empty())
//                 {
//                     this.root = newNode;
//                     this.size++;
//                     return;
//                 }
//                 locParent = Traverse(selectedNode, newNode.Value);

//                 if(locParent.Value == newNode.Value)
//                 {
//                     Console.WriteLine("This number has already been inserted");
//                     return;
//                 }
//                 else if(newNode.Value > locParent.Value)
//                 {
//                     locParent.Right = newNode;
//                 }
//                 else
//                 {
//                     locParent.Left = newNode;
//                 }

//                 this.size++;
//                 return;
//             }

//             public BSTNode Lookup(int lookupValue)
//             {
//                 BSTNode selectedNode = this.root;

//                 if(Empty())
//                 {
//                     Console.WriteLine("BST is empty.");
//                     return null;
//                 }

//                 while(selectedNode.Value != lookupValue)
//                 {
//                     if(selectedNode.Right == null && selectedNode.Left == null)
//                     {
//                         Console.WriteLine($"{lookupValue} is not in this BST.");
//                         return null;
//                     }

//                     selectedNode = Traverse(selectedNode, lookupValue);

//                     if(selectedNode.Value == lookupValue)
//                     {
//                         return selectedNode;
//                     }
//                 }

//                 return null;
//             }

//             public int Count()
//             {
//                 return this.size;
//             }

//             public bool Empty()
//             {
//                 if(this.root != null)
//                 {
//                     return false;
//                 }

//                 return true;
//             }

//             private BSTNode Traverse(BSTNode selectedNode, int value) // O(log n)
//             {
//                 BSTNode currentNode = selectedNode;
//                 while(true)
//                 {
//                     if(value == currentNode.Value)
//                     {
//                         return currentNode;
//                     }
                    
//                     if(value > currentNode.Value)
//                     {
//                         if(currentNode.Right == null)
//                         {
//                             return currentNode;
//                         }
//                         currentNode = currentNode.Right;
//                     }

//                     else if(value < currentNode.Value)
//                     {
//                         if(currentNode.Left == null)
//                         {
//                             return currentNode;
//                         }
//                         currentNode = currentNode.Left;
//                     }
//                 }
//             }

//             public List<int> BreadthFirstSearch()
//             {
//                 BSTNode currentNode = this.root;
//                 List<int> list = new List<int>();
//                 Queue<BSTNode> queue = new Queue<BSTNode>();

//                 queue.Enqueue(currentNode);

//                 while(queue.Count > 0)
//                 {
//                     currentNode = queue.Dequeue();
//                     //print the data as we are getting it
//                     Console.Write(currentNode.Value + " ");
//                     list.Add(currentNode.Value);
//                     if(currentNode.Left != null)
//                     {
//                         queue.Enqueue(currentNode.Left);
//                     }
//                     if(currentNode.Right != null)
//                     {
//                         queue.Enqueue(currentNode.Right);
//                     }
//                 }

//                 return list;
//             }

//             public List<int> BreadthFirstSearchRecursive(Queue<BSTNode> queue, List<int> list)
//             {
//                 if(queue.Count == 0 && list.Count == 0)
//                 {
//                     queue.Enqueue(this.root);
//                 }
//                 else if(queue.Count == 0)
//                 {
//                     return list;
//                 }

//                 BSTNode currentNode = queue.Dequeue();
//                 Console.Write(currentNode.Value + " ");
//                 list.Add(currentNode.Value);
//                 if(currentNode.Left != null)
//                 {
//                     queue.Enqueue(currentNode.Left);
//                 }
//                 if(currentNode.Right != null)
//                 {
//                     queue.Enqueue(currentNode.Right);
//                 }

//                 return this.BreadthFirstSearchRecursive(queue, list);
//             }

//             public List<int> DFSInOrder()
//             {
//                 List<int> list = new List<int>();
//                 return traverseInOrder(this.root, list);
//             }

//             public List<int> DFSPreOrder()
//             {
//                 List<int> list = new List<int>();
//                 return traversePreOrder(this.root, list);
//             }

//             public List<int> DFSPostOrder()
//             {
//                 List<int> list = new List<int>();
//                 return traversePostOrder(this.root, list);
//             }


//             public List<int> traverseInOrder(BSTNode node, List<int> list)
//             {
//                 //Console.WriteLine(node.Value);
//                 if(node.Left != null)
//                 {
//                     traverseInOrder(node.Left, list);
//                 }

//                 list.Add(node.Value);
//                 Console.Write(node.Value + " ");

//                 if(node.Right != null)
//                 {
//                     traverseInOrder(node.Right, list);
//                 }

//                 return list;
//             }

//             public List<int> traversePreOrder(BSTNode node, List<int> list)
//             {
//                 Console.Write(node.Value + " ");
//                 list.Add(node.Value);
//                 if(node.Left != null)
//                 {
//                     traversePreOrder(node.Left, list);
//                 }

//                 if(node.Right != null)
//                 {
//                     traversePreOrder(node.Right, list);
//                 }

//                 return list;
//             }
        
//             public List<int> traversePostOrder(BSTNode node, List<int> list)
//             {
//                 //Console.Write(node.Value + " ");
//                 if(node.Left != null)
//                 {
//                     traversePostOrder(node.Left, list);
//                 }

//                 if(node.Right != null)
//                 {
//                     traversePostOrder(node.Right, list);
//                 }

//                 Console.Write(node.Value + " ");
//                 list.Add(node.Value);
//                 return list;
//             }
//         }

//         static void Main(string[] args)
//         {
//             BST myBST = new BST();

//             myBST.Insert(9);
//             myBST.Insert(4);
//             myBST.Insert(20);
//             myBST.Insert(1);
//             myBST.Insert(6);
//             myBST.Insert(15);
//             myBST.Insert(170);
//             //myBST.Insert(1);


//             //BFS
//             //myBST.BreadthFirstSearch();

//             //BFSR
//             //Queue<BSTNode> queue = new Queue<BSTNode>();
//             //List<int> list = new List<int>();
//             //myBST.BreadthFirstSearchRecursive(queue, list);
            
//             //DFS
//             //myBST.DFSInOrder();
//             //myBST.DFSPreOrder();
//             //myBST.DFSPostOrder();

//             // BSTNode node = myBST.Lookup(20);
//             // Console.WriteLine(myBST.Empty());
//             // Console.WriteLine(myBST.Count());
//             // Console.WriteLine($"{node.Value}, {node.Left.Value}, {node.Right.Value}");
//         }
//     }
// }