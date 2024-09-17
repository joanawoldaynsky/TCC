public class Node {
    public bool Value;
    public Node Left, Right;

    public Node(bool value) {
        Value = value;
        Left = Right = null;
    }
}

public class BooleanBinaryTree {
    public Node Root;

    public BooleanBinaryTree() {
        Root = null;
    }

    public void Insert(bool value) {
        Root = InsertRec(Root, value);
    }

    private Node InsertRec(Node root, bool value) {
        if (root == null) {
            root = new Node(value);
            return root;
        }
        if (value) {
            root.Right = InsertRec(root.Right, value);
        } else {
            root.Left = InsertRec(root.Left, value);
        }
        return root;
    }

    // Outros métodos como busca, remoção, etc., podem ser adicionados aqui
}
