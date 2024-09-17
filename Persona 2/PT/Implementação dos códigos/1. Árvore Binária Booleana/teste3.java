public class teste3 {
    static class Node {
        boolean value;
        Node left, right;

        Node(boolean value) {
            this.value = value;
            left = right = null;
        }
    }

    Node root;

    public teste3() {
        root = null;
    }

    public void add(boolean value) {
        root = addRecursive(root, value);
    }

    private Node addRecursive(Node current, boolean value) {
        if (current == null) {
            return new Node(value);
        }

        if (value) {
            current.right = addRecursive(current.right, value);
        } else {
            current.left = addRecursive(current.left, value);
        }

        return current;
    }

    public void inOrderTraversal(Node node) {
        if (node != null) {
            inOrderTraversal(node.left);
            System.out.print(node.value + " ");
            inOrderTraversal(node.right);
        }
    }

    public static void main(String[] args) {
        teste3 tree = new teste3();
        tree.add(true);
        tree.add(false);
        tree.add(true);
        tree.add(false);
        
        tree.inOrderTraversal(tree.root);  // Output: false false true true 
    }
}
