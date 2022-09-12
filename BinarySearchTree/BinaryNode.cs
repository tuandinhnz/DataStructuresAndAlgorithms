namespace BinarySearchTree
{
    public class BinaryNode<TItem> where TItem : INodeItem
    {
        public TItem Item { get; set; }
        public BinaryNode<TItem>? Left { get; set; }
        public BinaryNode<TItem>? Right { get; set; }
        public BinaryNode<TItem>? Parent { get; set; }
        public BinaryNode(TItem item)
        {
            Item = item;
        }
        
        public void SubTree_Iter()
        {
            if (Left != null)
            {
                Left.SubTree_Iter();
            }
            
            Console.Write($"{Item.Key} ");
            
            if (Right != null)
            {
                Right.SubTree_Iter();
            }
        }
        
        public BinaryNode<TItem> SubTree_First()
        {
            if (Left != null)
            {
                return Left.SubTree_First();
            }

            return this;
        }
        
        public BinaryNode<TItem> SubTree_Last()
        {
            if (Right != null)
            {
                return Right.SubTree_Last();
            }

            return this;
        }
        public void SubTree_InsertBefore(BinaryNode<TItem> insertedNode)
        {
            if (Left != null)
            {
                var nodePredecessor = Left.SubTree_Last();
                nodePredecessor.Right = insertedNode;
                insertedNode.Parent = nodePredecessor;
            }
            else
            {
                Left = insertedNode;
                insertedNode.Parent = this;
            }
        }
        public void SubTree_InsertAfter(BinaryNode<TItem> insertedNode)
        {
            if (Right != null)
            {
                var nodeSuccessor = Right.SubTree_First();
                nodeSuccessor.Left = insertedNode;
                insertedNode.Parent = nodeSuccessor;
            }
            else
            {
                Right = insertedNode;
                insertedNode.Parent = this;
            }
        }

        public BinaryNode<TItem> GetSuccessor()
        {
            if (Right != null)
            {
                return Right.SubTree_First();
            }

            var node = this;
            
            while (node.Parent != null && node == node.Parent.Right)
            {
                node = node.Parent;
            }

            return node.Parent;
        }
        
        public BinaryNode<TItem> GetPredecessor()
        {
            if (Left != null)
            {
                return Left.SubTree_Last();
            }

            var node = this;
            
            while (node.Parent != null && node == node.Parent.Left)
            {
                node = node.Parent;
            }

            return node.Parent;
        }
        
        public BinaryNode<TItem> SubTree_Delete()
        {
            BinaryNode<TItem> nodeToSwap;
            
            if (Left != null || Right != null)
            {
                if (Left != null)
                {
                    nodeToSwap = GetPredecessor();
                }
                else
                {
                    nodeToSwap = GetSuccessor();
                }

                (Item, nodeToSwap.Item) = (nodeToSwap.Item, Item);

                return nodeToSwap.SubTree_Delete();
            }
            
            if (Parent != null)
            {
                if (Parent.Left == this)
                {
                    Parent.Left = null;
                }

                Parent.Right = null;
            }

            return this;
        }

        public BinaryNode<TItem>? SubTree_Find(int key)
        {
            if (key < Item.Key)
            {
                if (Left != null)
                {
                    return Left.SubTree_Find(key);
                }
            } 
            else if (key > Item.Key)
            {
                if (Right != null)
                {
                    return Right.SubTree_Find(key);
                }
            }
            else
            {
                return this;
            }
            
            return null;
        }
    }
}
