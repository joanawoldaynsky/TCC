using System;

public class BooleanAVLTree
{
    public class Node
    {
        public bool Data;
        public Node Left, Right;
        public int Height;

        public Node(bool data)
        {
            Data = data;
            Left = Right = null;
            Height = 1;
        }
    }

    public class AVLTree
    {
        public Node Root;

        public int Height(Node N) => N?.Height ?? 0;

        public int Max(int a, int b) => (a > b) ? a : b;

        public Node RightRotate(Node y)
        {
            Node x = y.Left;
            Node T2 = x.Right;

            x.Right = y;
            y.Left = T2;

            y.Height = Max(Height(y.Left), Height(y.Right)) + 1;
            x.Height = Max(Height(x.Left), Height(x.Right)) + 1;

            return x;
        }

        public Node LeftRotate(Node x)
        {
            Node y = x.Right;
            Node T2 = y.Left;

            y.Left = x;
            x.Right = T2;

            x.Height = Max(Height(x.Left), Height(x.Right)) + 1;
            y.Height = Max(Height(y.Left), Height(y.Right)) + 1;

            return y;
        }

        public int GetBalance(Node N) => N == null ? 0 : Height(N.Left) - Height(N.Right);

        public Node Insert(Node node, bool data)
        {
            if (node == null)
                return (new Node(data));

            if (data)
                node.Right = Insert(node.Right, data);
            else
                node.Left = Insert(node.Left, data);

            node.Height = 1 + Max(Height(node.Left), Height(node.Right));

            int balance = GetBalance(node);

            // Left Left Case
            if (balance > 1 && !data)
                return RightRotate(node);

            // Right Right Case
            if (balance < -1 && data)
                return LeftRotate(node);

            // Left Right Case
            if (balance > 1 && data)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }

            // Right Left Case
            if (balance < -1 && !data)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }

            return node;
        }

        public void Insert(bool data)
        {
            Root = Insert(Root, data);
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
        AVLTree tree = new AVLTree();
        Random rand = new Random();
        for (int i = 0; i < 1000; i++)
        {
            tree.Insert(rand.NextDouble() > 0.5);
        }
        tree.InOrder();
    }
}
