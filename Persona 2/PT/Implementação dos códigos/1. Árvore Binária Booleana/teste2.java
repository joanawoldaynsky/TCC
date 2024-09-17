class BooleanBinaryTreeNode {
    boolean value;
    BooleanBinaryTreeNode left;
    BooleanBinaryTreeNode right;

    public BooleanBinaryTreeNode(boolean value) {
        this.value = value;
        this.left = null;
        this.right = null;
    }
}

public class teste2 {
    BooleanBinaryTreeNode root;

    public teste2() {
        this.root = null;
    }

    public void insert(boolean value) {
        root = insertRec(root, value);
    }

    private BooleanBinaryTreeNode insertRec(BooleanBinaryTreeNode root, boolean value) {
        if (root == null) {
            root = new BooleanBinaryTreeNode(value);
            return root;
        }

        if (value) {
            root.right = insertRec(root.right, value);
        } else {
            root.left = insertRec(root.left, value);
        }

        return root;
    }

    // Additional methods for traversal, search, etc., can be added here

    public static void main(String[] args) {
        teste2 tree = new teste2();
        tree.insert(true);
        tree.insert(false);
        tree.insert(true);
        tree.insert(false);
    }
}
