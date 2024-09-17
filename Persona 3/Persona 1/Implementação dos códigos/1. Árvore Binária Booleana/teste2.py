import random


class Node:
    def __init__(self, data):
        self.data = data
        self.left = None
        self.right = None
        self.height = 1

class AVLTree:
    def __init__(self):
        self.root = None

    def insert(self, root, data):
        if not root:
            return Node(data)
        elif data < root.data:
            root.left = self.insert(root.left, data)
        else:
            root.right = self.insert(root.right, data)

        root.height = 1 + max(self.get_height(root.left),
                              self.get_height(root.right))

        balance = self.get_balance(root)

        if balance > 1 and data < root.left.data:
            return self.right_rotate(root)

        if balance < -1 and data > root.right.data:
            return self.left_rotate(root)

        if balance > 1 and data > root.left.data:
            root.left = self.left_rotate(root.left)
            return self.right_rotate(root)

        if balance < -1 and data < root.right.data:
            root.right = self.right_rotate(root.right)
            return self.left_rotate(root)

        return root

    def left_rotate(self, z):
        y = z.right
        T2 = y.left

        y.left = z
        z.right = T2

        z.height = 1 + max(self.get_height(z.left),
                           self.get_height(z.right))
        y.height = 1 + max(self.get_height(y.left),
                           self.get_height(y.right))

        return y

    def right_rotate(self, z):
        y = z.left
        T3 = y.right

        y.right = z
        z.left = T3

        z.height = 1 + max(self.get_height(z.left),
                           self.get_height(z.right))
        y.height = 1 + max(self.get_height(y.left),
                           self.get_height(y.right))

        return y

    def get_height(self, root):
        if not root:
            return 0
        return root.height

    def get_balance(self, root):
        if not root:
            return 0
        return self.get_height(root.left) - self.get_height(root.right)

    def in_order(self, root):
        if root:
            self.in_order(root.left)
            print(root.data, end=" ")
            self.in_order(root.right)

if __name__ == "__main__":
    tree = AVLTree()
    root = None
    for _ in range(1000):
        root = tree.insert(root, random.random() > 0.5)
    tree.in_order(root)
    print()
