class AVLNode:
    def __init__(self, value):
        self.value = value
        self.left = None
        self.right = None
        self.height = 1

class AVLTree:
    def __init__(self):
        self.root = None

    def add(self, value):
        self.root = self._add_recursive(self.root, value)

    def _add_recursive(self, node, value):
        if node is None:
            return AVLNode(value)
        
        if value < node.value:
            node.left = self._add_recursive(node.left, value)
        else:
            node.right = self._add_recursive(node.right, value)

        node.height = 1 + max(self._get_height(node.left), self._get_height(node.right))
        balance = self._get_balance(node)

        if balance > 1 and value < node.left.value:
            return self._rotate_right(node)
        if balance < -1 and value > node.right.value:
            return self._rotate_left(node)
        if balance > 1 and value > node.left.value:
            node.left = self._rotate_left(node.left)
            return self._rotate_right(node)
        if balance < -1 and value < node.right.value:
            node.right = self._rotate_right(node.right)
            return self._rotate_left(node)

        return node

    def _get_height(self, node):
        if not node:
            return 0
        return node.height

    def _get_balance(self, node):
        if not node:
            return 0
        return self._get_height(node.left) - self._get_height(node.right)

    def _rotate_left(self, z):
        y = z.right
        T2 = y.left
        y.left = z
        z.right = T2
        z.height = 1 + max(self._get_height(z.left), self._get_height(z.right))
        y.height = 1 + max(self._get_height(y.left), self._get_height(y.right))
        return y

    def _rotate_right(self, z):
        y = z.left
        T3 = y.right
        y.right = z
        z.left = T3
        z.height = 1 + max(self._get_height(z.left), self._get_height(z.right))
        y.height = 1 + max(self._get_height(y.left), self._get_height(y.right))
        return y

    def traverse_in_order(self):
        self._traverse_in_order_recursive(self.root)

    def _traverse_in_order_recursive(self, node):
        if node:
            self._traverse_in_order_recursive(node.left)
            print(node.value, end=' ')
            self._traverse_in_order_recursive(node.right)

if __name__ == "__main__":
    tree = AVLTree()
    tree.add(True)
    tree.add(False)
    tree.add(True)
    tree.traverse_in_order()
