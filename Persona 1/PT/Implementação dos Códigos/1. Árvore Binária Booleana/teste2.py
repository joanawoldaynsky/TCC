class Node:
    def __init__(self, value):
        self.value = value
        self.left = None
        self.right = None

class BinaryTree:
    def __init__(self):
        self.root = None

    def insert(self, value):
        if self.root is None:
            self.root = Node(value)
        else:
            self._insert(self.root, value)

    def _insert(self, current_node, value):
        if value:
            if current_node.right is None:
                current_node.right = Node(value)
            else:
                self._insert(current_node.right, value)
        else:
            if current_node.left is None:
                current_node.left = Node(value)
            else:
                self._insert(current_node.left, value)

    def inorder(self):
        self._inorder(self.root)

    def _inorder(self, node):
        if node:
            self._inorder(node.left)
            print(node.value, end=" ")
            self._inorder(node.right)

if __name__ == "__main__":
    tree = BinaryTree()
    tree.insert(True)
    tree.insert(False)
    tree.insert(True)
    tree.insert(False)
    tree.inorder()
