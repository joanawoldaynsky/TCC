class BooleanBinaryTreeNode:
    def __init__(self, value: bool):
        self.value = value
        self.left = None
        self.right = None

class BooleanBinaryTree:
    def __init__(self):
        self.root = None

    def insert(self, value: bool):
        if self.root is None:
            self.root = BooleanBinaryTreeNode(value)
        else:
            self._insert_rec(self.root, value)

    def _insert_rec(self, node: BooleanBinaryTreeNode, value: bool):
        if value:
            if node.right is None:
                node.right = BooleanBinaryTreeNode(value)
            else:
                self._insert_rec(node.right, value)
        else:
            if node.left is None:
                node.left = BooleanBinaryTreeNode(value)
            else:
                self._insert_rec(node.left, value)

    # Additional methods for traversal, search, etc., can be added here

# Example usage
tree = BooleanBinaryTree()
tree.insert(True)
tree.insert(False)
tree.insert(True)
tree.insert(False)
