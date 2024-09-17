public class teste3 {
    static class Node {
        boolean value;
        Node left, right;

        Node(boolean item) {
            value = item;
            left = right = null;
        }
    }

    Node root;

    teste3() {
        root = null;
    }

    // Insert a new boolean value into the tree
    void insert(boolean value) {
        root = insertRec(root, value);
    }

    Node insertRec(Node root, boolean value) {
        if (root == null) {
            root = new Node(value);
            return root;
        }

        if (value == false) {
            root.left = insertRec(root.left, value);
        } else {
            root.right = insertRec(root.right, value);
        }

        return root;
    }

    // Inorder traversal
    void inorder() {
        inorderRec(root);
    }

    void inorderRec(Node root) {
        if (root != null) {
            inorderRec(root.left);
            System.out.print(root.value + " ");
            inorderRec(root.right);
        }
    }

    public static void main(String[] args) {
        teste3 tree = new teste3();

        tree.insert(true);
        tree.insert(false);
        tree.insert(true);
        tree.insert(false);
        tree.insert(true);

        // Print inorder traversal of the Boolean Binary Tree
        tree.inorder();
    }
}
