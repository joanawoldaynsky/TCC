class Node:
    def __init__(self, value):
        self.value = value
        self.left = None
        self.right = None

class BooleanBinaryTree:
    def __init__(self):
        self.root = None

    def add(self, value):
        if self.root is None:
            self.root = Node(value)
        else:
            self._add_recursive(self.root, value)

    def _add_recursive(self, current, value):
        if value:
            if current.right is None:
                current.right = Node(value)
            else:
                self._add_recursive(current.right, value)
        else:
            if current.left is None:
                current.left = Node(value)
            else:
                self._add_recursive(current.left, value)

    def in_order_traversal(self, node):
        if node is not None:
            self.in_order_traversal(node.left)
            print(node.value, end=' ')
            self.in_order_traversal(node.right)

if __name__ == "__main__":
    tree = BooleanBinaryTree()
    tree.add(True)
    tree.add(False)
    tree.add(True)
    tree.add(False)

    tree.in_order_traversal(tree.root)  # Output: False False True True 
