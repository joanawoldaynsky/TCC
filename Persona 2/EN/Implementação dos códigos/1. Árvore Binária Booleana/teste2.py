class Node:
    def __init__(self, value: bool):
        self.value = value
        self.left = None
        self.right = None

class BooleanBinaryTree:
    def __init__(self):
        self.root = None

    def add(self, value: bool):
        if self.root is None:
            self.root = Node(value)
        else:
            self._add_recursive(self.root, value)

    def _add_recursive(self, current: Node, value: bool):
        if current.left is None:
            current.left = Node(value)
        elif current.right is None:
            current.right = Node(value)
        else:
            if self._has_space(current.left):
                self._add_recursive(current.left, value)
            else:
                self._add_recursive(current.right, value)

    def _has_space(self, node: Node):
        return node.left is None or node.right is None

# Example usage
if __name__ == "__main__":
    tree = BooleanBinaryTree()
    tree.add(True)
    tree.add(False)
    tree.add(True)
    # Additional operations can be performed here
