import random

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
        if random.random() < 0.5:
            if current.left is None:
                current.left = Node(value)
            else:
                self._add_recursive(current.left, value)
        else:
            if current.right is None:
                current.right = Node(value)
            else:
                self._add_recursive(current.right, value)

    def traverse_in_order(self):
        self._traverse_in_order_recursive(self.root)

    def _traverse_in_order_recursive(self, node):
        if node:
            self._traverse_in_order_recursive(node.left)
            print(node.value, end=' ')
            self._traverse_in_order_recursive(node.right)

if __name__ == "__main__":
    tree = BooleanBinaryTree()
    tree.add(True)
    tree.add(False)
    tree.add(True)
    tree.traverse_in_order()
