from typing import Optional
from collections import deque

class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Codec:

    def serialize(self, root: Optional[TreeNode]) -> str:
        if not root:
            return 'null'
        
        queue = deque([root])
        res = []
        
        while queue:
            node = queue.popleft()
            if node:
                res.append(str(node.val))
                queue.append(node.left)
                queue.append(node.right)
            else:
                res.append('null')
        
        return ','.join(res)

    def deserialize(self, data: str) -> Optional[TreeNode]:
        if data == 'null':
            return None
        
        nodes = data.split(',')
        root = TreeNode(int(nodes[0]))
        queue = deque([root])
        i = 1
        
        while queue:
            node = queue.popleft()
            if nodes[i] != 'null':
                node.left = TreeNode(int(nodes[i]))
                queue.append(node.left)
            i += 1
            if nodes[i] != 'null':
                node.right = TreeNode(int(nodes[i]))
                queue.append(node.right)
            i += 1
        
        return root

# Testando
if __name__ == "__main__":
    codec = Codec()
    root = TreeNode(1)
    root.left = TreeNode(2)
    root.right = TreeNode(3)
    root.right.left = TreeNode(4)
    root.right.right = TreeNode(5)

    serialized = codec.serialize(root)
    print("Serialized:", serialized)

    deserialized_root = codec.deserialize(serialized)
    deserialized_serialized = codec.serialize(deserialized_root)
    print("Deserialized and Serialized again:", deserialized_serialized)
