using System;

public class BooleanBinaryTree
{
    public class Node
    {
        public bool Data;
        public Node Left, Right;

        public Node(bool data)
        {
            Data = data;
            Left = Right = null;
        }
    }

    public class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(bool data)
        {
            Root = InsertRec(Root, data);
        }

        private Node InsertRec(Node root, bool data)
        {
            if (root == null)
            {
                root = new Node(data);
                return root;
            }

            Random rand = new Random();
            if (rand.NextDouble() > 0.5)
            {
                root.Left = InsertRec(root.Left, data);
            }
            else
            {
                root.Right = InsertRec(root.Right, data);
            }

            return root;
        }

        public void InOrder()
        {
            InOrderRec(Root);
            Console.WriteLine();
        }

        private void InOrderRec(Node root)
        {
            if (root != null)
            {
                InOrderRec(root.Left);
                Console.Write(root.Data + " ");
                InOrderRec(root.Right);
            }
        }
    }

    public static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();
        for (int i = 0; i < 1000; i++)
        {
            Random rand = new Random();
            tree.Insert(rand.NextDouble() > 0.5);
        }
        tree.InOrder();
    }
}
