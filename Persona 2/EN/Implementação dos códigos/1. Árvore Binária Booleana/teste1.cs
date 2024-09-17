using System;

class TreeNode {
    public bool val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(bool x) {
        val = x;
    }
}

class BooleanBinaryTree {
    public TreeNode root;

    public BooleanBinaryTree(bool rootVal) {
        root = new TreeNode(rootVal);
    }

    public void InsertLeft(TreeNode parent, bool value) {
        parent.left = new TreeNode(value);
    }

    public void InsertRight(TreeNode parent, bool value) {
        parent.right = new TreeNode(value);
    }

    public void PreorderTraversal(TreeNode node) {
        if (node != null) {
            Console.Write(node.val + " ");
            PreorderTraversal(node.left);
            PreorderTraversal(node.right);
        }
    }

    public static void Main(string[] args) {
        BooleanBinaryTree tree = new BooleanBinaryTree(true);
        tree.InsertLeft(tree.root, false);
        tree.InsertRight(tree.root, true);
        tree.PreorderTraversal(tree.root);
    }
}
