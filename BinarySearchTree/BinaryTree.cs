namespace BinarySearchTree

{
    public class BinaryTree<TNode, TItem> where TNode : BinaryNode<TItem> where TItem : INodeItem
    {
        public TNode? Root { get; set; }
        public int Size { get; set; } = 0;

        public void Iter()
        {
            Root?.SubTree_Iter();
        }

    }
}
