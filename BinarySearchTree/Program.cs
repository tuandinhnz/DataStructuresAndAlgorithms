// See https://aka.ms/new-console-template for more information

using BinarySearchTree;

var binaryTree = new BinaryTree<BinaryNode<NodeItem>, NodeItem>();
var node13 = new BinaryNode<NodeItem>(new NodeItem(13));
binaryTree.Root = node13;
var node27 = new BinaryNode<NodeItem>(new NodeItem(27));
var node15 = new BinaryNode<NodeItem>(new NodeItem(15));
var node16 = new BinaryNode<NodeItem>(new NodeItem(16));
node13.SubTree_InsertAfter(node27);
node27.SubTree_InsertBefore(node15);
node27.SubTree_InsertBefore(node16);
binaryTree.Root.SubTree_Delete();
Console.WriteLine(binaryTree.Root.Item.Key);
binaryTree.Root.SubTree_Iter();



