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

    def _insert_rec(self, root, value):
        if root is None:
            return Node(value)
        if value:
            root.right = self._insert_rec(root.right, value)
        else:
            root.left = self._insert_rec(root.left, value)
        return root

    def inorder(self):
        self._inorder_rec(self.root)

    def _inorder_rec(self, root):
        if root is not None:
            self._inorder_rec(root.left)
            print(root.value, end=" ")
            self._inorder_rec(root.right)

if __name__ == "__main__":
    tree = BooleanBinaryTree()
    tree.insert(True)
    tree.insert(False)
    tree.insert(True)
    tree.insert(False)
    tree.insert(True)

    print("Inorder traversal:")
    tree.inorder()
