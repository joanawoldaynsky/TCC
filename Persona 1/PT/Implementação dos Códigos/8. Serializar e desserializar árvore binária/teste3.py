class TreeNode:
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Codec:
    def serialize(self, root):
        """Serializes a tree to a single string."""
        def rserialize(root, string):
            if root is None:
                string += 'None,'
            else:
                string += str(root.val) + ','
                string = rserialize(root.left, string)
                string = rserialize(root.right, string)
            return string

        return rserialize(root, '')

    def deserialize(self, data):
        """Deserializes your encoded data to tree."""
        def rdeserialize(l):
            if l[0] == 'None':
                l.pop(0)
                return None

            root = TreeNode(int(l[0]))
            l.pop(0)
            root.left = rdeserialize(l)
            root.right = rdeserialize(l)
            return root

        data_list = data.split(',')
        root = rdeserialize(data_list)
        return root

# Teste
codec = Codec()
root = TreeNode(1)
root.left = TreeNode(2)
root.right = TreeNode(3)
root.left.left = TreeNode(4)
root.left.right = TreeNode(5)

serialized = codec.serialize(root)
print("Serialized:", serialized)

deserialized = codec.deserialize(serialized)
print("Deserialized Root:", deserialized.val)
