class Node:
    def __init__(self, value):
        self.value = value
        self.left = None
        self.right = None

class BooleanBinaryTree:
    def __init__(self):
        self.root = None

    def insert(self, value):
        if self.root is None:
            self.root = Node(value)
        else:
            self._insert(self.root, value)

    def _insert(self, current, value):
        if value == False:
            if current.left is None:
                current.left = Node(value)
            else:
                self._insert(current.left, value)
        else:
            if current.right is None:
                current.right = Node(value)
            else:
                self._insert(current.right, value)

    def inorder(self):
        self._inorder(self.root)

    def _inorder(self, node):
        if node is not None:
            self._inorder(node.left)
            print(node.value, end=" ")
            self._inorder(node.right)

if __name__ == "__main__":
    tree = BooleanBinaryTree()
    tree.insert(True)
    tree.insert(False)
    tree.insert(True)
    tree.insert(False)
    tree.insert(True)

    # Print inorder traversal of the Boolean Binary Tree
    tree.inorder()
