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
            return json.dumps(None)
        
        queue = deque([root])
        res = []
        
        while queue:
            node = queue.popleft()
            if node:
                res.append(node.val)
                queue.append(node.left)
                queue.append(node.right)
            else:
                res.append(None)
        
        return json.dumps(res)

    def deserialize(self, data):
        if data == 'null':
            return None
        
        nodes = json.loads(data)
        if not nodes:
            return None
        
        root = TreeNode(nodes[0])
        queue = deque([root])
        i = 1
        
        while queue:
            node = queue.popleft()
            if nodes[i] is not None:
                node.left = TreeNode(nodes[i])
                queue.append(node.left)
            i += 1
            if nodes[i] is not None:
                node.right = TreeNode(nodes[i])
                queue.append(node.right)
            i += 1
        
        return root

# Example usage:
codec = Codec()
root = TreeNode(1)
root.left = TreeNode(2)
root.right = TreeNode(3)
root.right.left = TreeNode(4)
root.right.right = TreeNode(5)

serialized_data = codec.serialize(root)
print("Serialized data:", serialized_data)

deserialized_root = codec.deserialize(serialized_data)
print("Deserialized tree root value:", deserialized_root.val)
