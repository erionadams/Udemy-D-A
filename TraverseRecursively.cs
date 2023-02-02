// namespace TraverseRecursively
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

//             public BSTNode Traverse(BSTNode selectedNode, int value) // O(log n)
//             {
//                 BSTNode currentNode = selectedNode;

//                 if(value == currentNode.Value)
//                 {
//                     return currentNode;
//                 }
                
//                 if(value > currentNode.Value)
//                 {
//                     if(currentNode.Right == null)
//                     {
//                         return currentNode;
//                     }
//                     currentNode = currentNode.Right;
//                 }

//                 else if(value < currentNode.Value)
//                 {
//                     if(currentNode.Left == null)
//                     {
//                         return currentNode;
//                     }
//                     currentNode = currentNode.Left;
//                 }

//                 return Traverse(currentNode, value);
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
//             myBST.Insert(1);

//             BSTNode node = myBST.Lookup(20); //Traversing for "20"
//             Console.WriteLine(myBST.Empty());
//             Console.WriteLine(myBST.Count());
//             Console.WriteLine($"{node.Value}, {node.Left.Value}, {node.Right.Value}");

               //BST should look like:
//             //      9
//             //  4       20
//             //1   6   15  170
//         }
//     }
// }