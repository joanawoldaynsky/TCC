// Classe para o nó da árvore
class Node {
    boolean value;
    Node left, right;

    public Node(boolean value) {
        this.value = value;
        left = right = null;
    }
}

// Classe para a árvore binária
public class teste1 {
    Node root;

    // Construtor
    public teste1() {
        root = null;
    }

    // Método para inserir um novo nó na árvore
    public void insert(boolean value) {
        root = insertRec(root, value);
    }

    // Função recursiva para inserir um novo nó
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

    // Outros métodos como busca, remoção, etc., podem ser adicionados aqui
}
