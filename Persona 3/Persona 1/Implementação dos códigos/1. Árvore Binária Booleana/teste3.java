/*private Node addRecursive(Node current, boolean value) {
    if (current == null) {
        return new Node(value);
    }
    if (value == current.value) {
        return current; // Valor já existe na árvore, não faz nada
    } else if (value) {
        current.right = addRecursive(current.right, value);
    } else {
        current.left = addRecursive(current.left, value);
    }
    return current;
}*/
