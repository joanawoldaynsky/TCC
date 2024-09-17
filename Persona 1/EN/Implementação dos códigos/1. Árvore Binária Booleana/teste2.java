public class teste2 {
    // Node class
    static class Node {
        boolean data;
        Node left, right;

        Node(boolean data) {
            this.data = data;
            left = right = null;
        }
    }

    // Binary tree class
    static class BinaryTree {
        Node root;

        BinaryTree() {
            root = null;
        }

        // Insert data into the tree
        void insert(boolean data) {
            root = insertRec(root, data);
        }

        Node insertRec(Node root, boolean data) {
            if (root == null) {
                root = new Node(data);
                return root;
            }
            if (Math.random() > 0.5) {
                root.left = insertRec(root.left, data);
            } else {
                root.right = insertRec(root.right, data);
            }
            return root;
        }

        // Print tree in-order
        void inOrder() {
            inOrderRec(root);
        }

        void inOrderRec(Node root) {
            if (root != null) {
                inOrderRec(root.left);
                System.out.print(root.data + " ");
                inOrderRec(root.right);
            }
        }
    }

    public static void main(String[] args) {
        BinaryTree tree = new BinaryTree();
        for (int i = 0; i < 1000; i++) {
            tree.insert(Math.random() > 0.5);
        }
        tree.inOrder();
    }
}
