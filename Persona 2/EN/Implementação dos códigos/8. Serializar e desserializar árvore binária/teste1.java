import java.util.*;

public class teste1 {
    static class TreeNode {
        int val;
        TreeNode left;
        TreeNode right;
        
        TreeNode(int x) {
            val = x;
        }
    }

    // Serialize a binary tree to a string
    public String serialize(TreeNode root) {
        if (root == null) {
            return "null,";
        }
        return root.val + "," + serialize(root.left) + serialize(root.right);
    }

    // Deserialize a string to a binary tree
    public TreeNode deserialize(String data) {
        Queue<String> nodes = new LinkedList<>(Arrays.asList(data.split(",")));
        return deserializeHelper(nodes);
    }

    private TreeNode deserializeHelper(Queue<String> nodes) {
        String val = nodes.poll();
        if (val.equals("null")) {
            return null;
        }
        TreeNode node = new TreeNode(Integer.parseInt(val));
        node.left = deserializeHelper(nodes);
        node.right = deserializeHelper(nodes);
        return node;
    }

    public static void main(String[] args) {
        teste1 tree = new teste1();
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.right.left = new TreeNode(4);
        root.right.right = new TreeNode(5);

        String serializedData = tree.serialize(root);
        System.out.println("Serialized: " + serializedData);

        TreeNode deserializedRoot = tree.deserialize(serializedData);
        System.out.println("Deserialized: " + tree.serialize(deserializedRoot)); // should match serializedData
    }
}
