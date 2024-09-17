import json
from collections import deque

class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Codec:
    def serialize(self, root):
        if not root:
            return "null"
        queue = deque([root])
        result = []
        while queue:
            node = queue.popleft()
            if node:
                result.append(node.val)
                queue.append(node.left)
                queue.append(node.right)
            else:
                result.append(None)
        return json.dumps(result)

    def deserialize(self, data):
        if data == "null":
            return None
        nodes = json.loads(data)
        root = TreeNode(nodes[0])
        queue = deque([root])
        index = 1
        while queue:
            node = queue.popleft()
            if nodes[index] is not None:
                node.left = TreeNode(nodes[index])
                queue.append(node.left)
            index += 1
            if nodes[index] is not None:
                node.right = TreeNode(nodes[index])
                queue.append(node.right)
            index += 1
        return root
