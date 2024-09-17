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
                return "null,"
            return str(node.val) + "," + serialize_helper(node.left) + serialize_helper(node.right)
        
        return serialize_helper(root)

    def deserialize(self, data):
        """Decodes your encoded data to tree."""
        def deserialize_helper(nodes):
            val = nodes.pop(0)
            if val == "null":
                return None
            node = TreeNode(int(val))
            node.left = deserialize_helper(nodes)
            node.right = deserialize_helper(nodes)
            return node

        nodes = data.split(',')
        root = deserialize_helper(nodes)
        return root

# Example usage
if __name__ == "__main__":
    tree = TreeNode(1)
    tree.left = TreeNode(2)
    tree.right = TreeNode(3)
    tree.right.left = TreeNode(4)
    tree.right.right = TreeNode(5)

    codec = Codec()
    serialized_data = codec.serialize(tree)
    print("Serialized:", serialized_data)

    deserialized_tree = codec.deserialize(serialized_data)
    print("Deserialized:", codec.serialize(deserialized_tree))  # should match serialized_data
