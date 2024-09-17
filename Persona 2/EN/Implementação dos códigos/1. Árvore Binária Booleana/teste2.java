public class teste2 {
    static class Node {
        boolean value;
        Node left;
        Node right;

        Node(boolean value) {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }

    Node root;

    public teste2() {
        this.root = null;
    }

    public void add(boolean value) {
        root = addRecursive(root, value);
    }

    private Node addRecursive(Node current, boolean value) {
        if (current == null) {
            return new Node(value);
        }

        if (!current.left) {
            current.left = addRecursive(current.left, value);
        } else if (!current.right) {
            current.right = addRecursive(current.right, value);
        }

        return current;
    }

    public static void main(String[] args) {
        teste2 tree = new teste2();
        tree.add(true);
        tree.add(false);
        tree.add(true);
        // Additional operations can be performed here
    }
}
