class Node {
    boolean value;
    Node left, right;

    public Node(boolean value) {
        this.value = value;
        left = right = null;
    }
}

// BinaryTree class
public class teste2 {
    Node root;

    // Insert method
    public void insert(boolean value) {
        root = insertRec(root, value);
    }

    private Node insertRec(Node root, boolean value) {
        if (root == null) {
            root = new Node(value);
            return root;
        }
        if (value) {
            root.right = insertRec(root.right, value);
        } else {
            root.left = insertRec(root.left, value);
        }
        return root;
    }

    // Inorder traversal
    public void inorder() {
        inorderRec(root);
    }

    private void inorderRec(Node root) {
        if (root != null) {
            inorderRec(root.left);
            System.out.print(root.value + " ");
            inorderRec(root.right);
        }
    }

    public static void main(String[] args) {
        teste2 tree = new teste2();
        tree.insert(true);
        tree.insert(false);
        tree.insert(true);
        tree.insert(false);
        tree.inorder();
    }
}
