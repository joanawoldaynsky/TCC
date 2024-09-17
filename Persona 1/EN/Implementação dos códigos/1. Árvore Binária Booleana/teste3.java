// BooleanBinaryTree.java
public class teste3 {
    private static class Node {
        boolean value;
        Node left, right;

        Node(boolean value) {
            this.value = value;
            left = right = null;
        }
    }

    private Node root;

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
        teste3 tree = new teste3();
        tree.insert(true);
        tree.insert(false);
        tree.insert(true);
        tree.insert(false);
        tree.insert(true);

        System.out.println("Inorder traversal:");
        tree.inorder();
    }
}
