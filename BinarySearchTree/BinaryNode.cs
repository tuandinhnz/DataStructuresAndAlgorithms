namespace BinarySearchTree
{
    public class BinaryNode<TItem>
    {
        public TItem Item { get; set; }
        public BinaryNode<TItem>? Left { get; set; }
        public BinaryNode<TItem>? Right { get; set; }
        public BinaryNode<TItem>? Parent { get; set; }
        public BinaryNode(TItem item)
        {
            Item = item;
        }
        
        public static void SubTree_Iter(BinaryNode<TItem> node)
        {
            if (node.Left != null)
            {
                SubTree_Iter(node.Left);
            }
            Console.Write($"{node.Item} ");
            if (node.Right != null)
            {
                SubTree_Iter(node.Right);
            }
        }
        public static void SubTree_InsertBefore(BinaryNode<TItem> node, BinaryNode<TItem> insertedNode)
        {
            if (node.Left != null)
            {
                var nodePredecessor = SubTree_Last(node.Left);
                nodePredecessor.Right = insertedNode;
                insertedNode.Parent = nodePredecessor;
            }
            else
            {
                node.Left = insertedNode;
                insertedNode.Parent = node;
            }
        }
        public static void SubTree_InsertAfter(BinaryNode<TItem> node, BinaryNode<TItem> insertedNode)
        {
            if (node.Right != null)
            {
                var nodeSuccessor = SubTree_First(node.Right);
                nodeSuccessor.Left = insertedNode;
                insertedNode.Parent = nodeSuccessor;
            }
            else
            {
                node.Right = insertedNode;
                insertedNode.Parent = node;
            }
        }

        public static BinaryNode<TItem> SubTree_First(BinaryNode<TItem> node)
        {
            if (node.Left != null)
            {
                return SubTree_First(node.Left);
            }

            return node;
        }
        
        public static BinaryNode<TItem> SubTree_Last(BinaryNode<TItem> node)
        {
            if (node.Right != null)
            {
                return SubTree_Last(node.Right);
            }

            return node;
        }
    }
}
