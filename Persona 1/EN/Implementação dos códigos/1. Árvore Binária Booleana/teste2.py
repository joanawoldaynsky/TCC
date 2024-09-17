import random

class Node:
    def __init__(self, data):
        self.data = data
        self.left = None
        self.right = None

class BinaryTree:
    def __init__(self):
        self.root = None

    def insert(self, data):
        if self.root is None:
            self.root = Node(data)
        else:
            self._insert(self.root, data)

    def _insert(self, node, data):
        if random.random() > 0.5:
            if node.left is None:
                node.left = Node(data)
            else:
                self._insert(node.left, data)
        else:
            if node.right is None:
                node.right = Node(data)
            else:
                self._insert(node.right, data)

    def in_order(self):
        self._in_order(self.root)
        print()

    def _in_order(self, node):
        if node is not None:
            self._in_order(node.left)
            print(node.data, end=' ')
            self._in_order(node.right)

if __name__ == "__main__":
    tree = BinaryTree()
    for _ in range(1000):
        tree.insert(random.random() > 0.5)
    tree.in_order()
