from typing import Optional
from collections import deque

class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Codec:

    def serialize(self, root: Optional[TreeNode]) -> str:
        def dfs(node):
            if not node:
                return 'null,'
            return str(node.val) + ',' + dfs(node.left) + dfs(node.right)
        
        return dfs(root)

    def deserialize(self, data: str) -> Optional[TreeNode]:
        def dfs(nodes):
            val = next(nodes)
            if val == 'null':
                return None
            node = TreeNode(int(val))
            node.left = dfs(nodes)
            node.right = dfs(nodes)
            return node
        
        return dfs(iter(data.split(',')))


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
