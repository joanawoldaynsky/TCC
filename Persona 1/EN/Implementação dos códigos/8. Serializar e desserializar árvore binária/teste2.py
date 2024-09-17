class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

class Codec:

    def serialize(self, root):
        """Encodes a tree to a single string."""
        def serialize_helper(node):
            if not node:
                vals.append('#')
                return
            vals.append(str(node.val))
            serialize_helper(node.left)
            serialize_helper(node.right)
        
        vals = []
        serialize_helper(root)
        return ' '.join(vals)

    def deserialize(self, data):
        """Decodes your encoded data to tree."""
        def deserialize_helper():
            val = next(vals)
            if val == '#':
                return None
            node = TreeNode(int(val))
            node.left = deserialize_helper()
            node.right = deserialize_helper()
            return node
        
        vals = iter(data.split())
        return deserialize_helper()

# Usage
# codec = Codec()
# tree_string = codec.serialize(root)
# root = codec.deserialize(tree_string)
