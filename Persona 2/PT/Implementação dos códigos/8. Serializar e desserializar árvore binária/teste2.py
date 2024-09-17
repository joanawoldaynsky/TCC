from typing import Optional, List

class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

class Codec:
    def serialize(self, root: Optional[TreeNode]) -> str:
        def helper(node: Optional[TreeNode]) -> str:
            if not node:
                return "null,"
            return str(node.val) + "," + helper(node.left) + helper(node.right)
        
        return helper(root)

    def deserialize(self, data: str) -> Optional[TreeNode]:
        def helper(nodes: List[str]) -> Optional[TreeNode]:
            if nodes[0] == "null":
                nodes.pop(0)
                return None
            root = TreeNode(int(nodes.pop(0)))
            root.left = helper(nodes)
            root.right = helper(nodes)
            return root
        
        node_list = data.split(',')
        return helper(node_list)
