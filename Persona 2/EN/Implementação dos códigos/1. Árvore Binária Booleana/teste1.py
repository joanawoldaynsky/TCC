class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class BooleanBinaryTree:
    def __init__(self, root_val):
        self.root = TreeNode(root_val)

    def insert_left(self, parent, value):
        parent.left = TreeNode(value)

    def insert_right(self, parent, value):
        parent.right = TreeNode(value)

    def preorder_traversal(self, node):
        if node:
            print(node.val, end=" ")
            self.preorder_traversal(node.left)
            self.preorder_traversal(node.right)

# Example usage
tree = BooleanBinaryTree(True)
tree.insert_left(tree.root, False)
tree.insert_right(tree.root, True)
tree.preorder_traversal(tree.root)
