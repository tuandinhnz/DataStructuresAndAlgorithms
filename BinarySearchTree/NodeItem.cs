namespace BinarySearchTree
{
    public class NodeItem : INodeItem
    {
        public int Key { get; set; }

        public NodeItem(int key)
        {
            Key = key;
        }
    }
}
