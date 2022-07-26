// See https://aka.ms/new-console-template for more information

using BinarySearchTree;

var binaryTree = new BinaryTree<BinaryNode<int>>();
var node13 = new BinaryNode<int>(13);
binaryTree.Root = node13;
var node27 = new BinaryNode<int>(27);
var node15 = new BinaryNode<int>(15);
var node16 = new BinaryNode<int>(16);
BinaryNode<int>.SubTree_InsertAfter(node13, node27);
BinaryNode<int>.SubTree_InsertBefore(node27, node15);
BinaryNode<int>.SubTree_InsertBefore(node27, node16);
BinaryNode<int>.SubTree_Iter(node13);



