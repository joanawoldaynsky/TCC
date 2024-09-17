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

    def _insert(self, root, value):
        if value:
            if root.right is None:
                root.right = Node(value)
            else:
                self._insert(root.right, value)
        else:
            if root.left is None:
                root.left = Node(value)
            else:
                self._insert(root.left, value)

    def inorder(self):
        self._inorder(self.root)

    def _inorder(self, root):
        if root:
            self._inorder(root.left)
            print(root.value, end=' ')
            self._inorder(root.right)

# Usage
tree = BinaryTree()
tree.insert(True)
tree.insert(False)
tree.insert(True)

tree.inorder()
