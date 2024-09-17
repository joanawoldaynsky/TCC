class Node:
    def __init__(self, value):
        self.value = value
        self.left = None
        self.right = None

class BooleanBinaryTree:
    def __init__(self):
        self.root = None

    def insert(self, value):
        self.root = self._insert_rec(self.root, value)

    def _insert_rec(self, node, value):
        if node is None:
            return Node(value)
        if value:
            node.right = self._insert_rec(node.right, value)
        else:
            node.left = self._insert_rec(node.left, value)
        return node

    # Outros métodos como busca, remoção, etc., podem ser adicionados aqui
