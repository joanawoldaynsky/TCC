public class teste2 {

    class Node {
        boolean data;
        Node left, right;
        int height;

        Node(boolean d) {
            data = d;
            height = 1;
        }
    }

    Node root;

    // Get the height of the node
    int height(Node N) {
        if (N == null)
            return 0;
        return N.height;
    }

    // Rotate right
    Node rightRotate(Node y) {
        Node x = y.left;
        Node T2 = x.right;
        x.right = y;
        y.left = T2;
        y.height = Math.max(height(y.left), height(y.right)) + 1;
        x.height = Math.max(height(x.left), height(x.right)) + 1;
        return x;
    }

    // Rotate left
    Node leftRotate(Node x) {
        Node y = x.right;
        Node T2 = y.left;
        y.left = x;
        x.right = T2;
        x.height = Math.max(height(x.left), height(x.right)) + 1;
        y.height = Math.max(height(y.left), height(y.right)) + 1;
        return y;
    }

    // Get the balance factor
    int getBalance(Node N) {
        if (N == null)
            return 0;
        return height(N.left) - height(N.right);
    }

    // Insert node into the AVL tree
    Node insert(Node node, boolean data) {
        if (node == null)
            return (new Node(data));

        if (data) {
            node.left = insert(node.left, data);
        } else {
            node.right = insert(node.right, data);
        }

        node.height = 1 + Math.max(height(node.left), height(node.right));

        int balance = getBalance(node);

        if (balance > 1 && data) {
            return rightRotate(node);
        }

        if (balance < -1 && !data) {
            return leftRotate(node);
        }

        if (balance > 1 && !data) {
            node.left = leftRotate(node.left);
            return rightRotate(node);
        }

        if (balance < -1 && data) {
            node.right = rightRotate(node.right);
            return leftRotate(node);
        }

        return node;
    }

    void insert(boolean data) {
        root = insert(root, data);
    }

    void inOrder(Node node) {
        if (node != null) {
            inOrder(node.left);
            System.out.print(node.data + " ");
            inOrder(node.right);
        }
    }

    public static void main(String[] args) {
        teste2 tree = new teste2();
        for (int i = 0; i < 1000; i++) {
            tree.insert(Math.random() > 0.5);
        }
        tree.inOrder(tree.root);
    }
}
