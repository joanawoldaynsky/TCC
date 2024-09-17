class TreeNode {
    boolean val;
    TreeNode left;
    TreeNode right;

    TreeNode(boolean x) {
        val = x;
    }
}

public class teste1 {
    TreeNode root;

    public teste1 (boolean rootVal) {
        root = new TreeNode(rootVal);
    }

    public void insertLeft(TreeNode parent, boolean value) {
        parent.left = new TreeNode(value);
    }

    public void insertRight(TreeNode parent, boolean value) {
        parent.right = new TreeNode(value);
    }

    // Preorder traversal
    public void preorderTraversal(TreeNode node) {
        if (node != null) {
            System.out.print(node.val + " ");
            preorderTraversal(node.left);
            preorderTraversal(node.right);
        }
    }

    public static void main(String[] args) {
        teste1 tree = new teste1(true);
        tree.insertLeft(tree.root, false);
        tree.insertRight(tree.root, true);
        tree.preorderTraversal(tree.root);
    }
}
