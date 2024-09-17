using System;
using System.Collections.Generic;
using System.Text;

public class BinaryTreeSerialization {

    // Definição da classe TreeNode
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    // Classe para serializar e desserializar a árvore
    public class Codec {

        // Serializa a árvore em uma string
        public string Serialize(TreeNode root) {
            if (root == null) {
                return "";
            }
            var queue = new Queue<TreeNode>();
            var sb = new StringBuilder();
            queue.Enqueue(root);

            while (queue.Count > 0) {
                var node = queue.Dequeue();
                if (node == null) {
                    sb.Append("null,");
                } else {
                    sb.Append(node.val).Append(",");
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            }
            return sb.ToString();
        }

        // Desserializa a string de volta em uma árvore
        public TreeNode Deserialize(string data) {
            if (string.IsNullOrEmpty(data)) {
                return null;
            }
            var nodes = data.Split(',');
            var root = new TreeNode(int.Parse(nodes[0]));
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int i = 1;

            while (queue.Count > 0 && i < nodes.Length) {
                var node = queue.Dequeue();
                if (nodes[i] != "null") {
                    node.left = new TreeNode(int.Parse(nodes[i]));
                    queue.Enqueue(node.left);
                }
                i++;
                if (i < nodes.Length && nodes[i] != "null") {
                    node.right = new TreeNode(int.Parse(nodes[i]));
                    queue.Enqueue(node.right);
                }
                i++;
            }
            return root;
        }
    }

    // Teste
    public static void Main(string[] args) {
        Codec codec = new Codec();
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.right.left = new TreeNode(4);
        root.right.right = new TreeNode(5);

        string serialized = codec.Serialize(root);
        Console.WriteLine("Serialized: " + serialized);

        TreeNode deserialized = codec.Deserialize(serialized);
        Console.WriteLine("Deserialized: " + codec.Serialize(deserialized));
    }
}
