from collections import deque

class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Codec:
    def serialize(self, root):
        if not root:
            return ""
        result = []
        queue = deque([root])
        while queue:
            node = queue.popleft()
            if node:
                result.append(str(node.val))
                queue.append(node.left)
                queue.append(node.right)
            else:
                result.append("null")
        return ",".join(result)

    def deserialize(self, data):
        if not data:
            return None
        nodes = data.split(",")
        root = TreeNode(int(nodes[0]))
        queue = deque([root])
        i = 1
        while queue:
            node = queue.popleft()
            if nodes[i] != "null":
                node.left = TreeNode(int(nodes[i]))
                queue.append(node.left)
            i += 1
            if nodes[i] != "null":
                node.right = TreeNode(int(nodes[i]))
                queue.append(node.right)
            i += 1
        return root
