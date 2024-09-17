class Node {
    boolean value;
    Node left, right;

    public Node(boolean item) {
        value = item;
        left = right = null;
    }
}

public class teste1 {
    Node root;

    teste1() {
        root = null;
    }

    void insert(boolean value) {
        root = insertRec(root, value);
    }

    Node insertRec(Node root, boolean value) {
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
        teste1 tree = new teste1();
        tree.insert(true);
        tree.insert(false);
        tree.insert(true);

        tree.inorder();
    }
}    