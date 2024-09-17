from collections import deque

class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Codec:

    def serialize(self, root):
        def rserialize(node):
            if not node:
                return "X,"
            return str(node.val) + "," + rserialize(node.left) + rserialize(node.right)
        
        return rserialize(root)

    def deserialize(self, data):
        def rdeserialize(nodes):
            val = nodes.popleft()
            if val == "X":
                return None
            node = TreeNode(int(val))
            node.left = rdeserialize(nodes)
            node.right = rdeserialize(nodes)
            return node
        
        node_list = deque(data.split(","))
        return rdeserialize(node_list)
