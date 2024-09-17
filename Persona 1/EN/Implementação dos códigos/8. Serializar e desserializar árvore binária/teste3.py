class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Codec:

    def serialize(self, root):
        """Encodes a tree to a single string."""
        def serializeHelper(node):
            if not node:
                return "null,"
            return str(node.val) + "," + serializeHelper(node.left) + serializeHelper(node.right)
        
        return serializeHelper(root)

    def deserialize(self, data):
        """Decodes your encoded data to tree."""
        def deserializeHelper(nodes):
            val = nodes.pop(0)
            if val == "null":
                return None
            node = TreeNode(int(val))
            node.left = deserializeHelper(nodes)
            node.right = deserializeHelper(nodes)
            return node
        
        node_list = data.split(',')
        return deserializeHelper(node_list)

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
    reserialized = codec.serialize(deserialized_root)
    print("Reserialized:", reserialized)
