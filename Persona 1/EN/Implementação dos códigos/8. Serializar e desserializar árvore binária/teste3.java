import java.util.*;

public class teste3 {

    public static class TreeNode {
        int val;
        TreeNode left;
        TreeNode right;

        TreeNode(int x) {
            val = x;
        }
    }

    public static class Codec {

        // Encodes a tree to a single string.
        public String serialize(TreeNode root) {
            StringBuilder sb = new StringBuilder();
            serializeHelper(root, sb);
            return sb.toString();
        }

        private void serializeHelper(TreeNode node, StringBuilder sb) {
            if (node == null) {
                sb.append("null,");
            } else {
                sb.append(node.val).append(",");
                serializeHelper(node.left, sb);
                serializeHelper(node.right, sb);
            }
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(String data) {
            Queue<String> nodes = new LinkedList<>(Arrays.asList(data.split(",")));
            return deserializeHelper(nodes);
        }

        private TreeNode deserializeHelper(Queue<String> nodes) {
            String val = nodes.poll();
            if ("null".equals(val)) {
                return null;
            } else {
                TreeNode node = new TreeNode(Integer.parseInt(val));
                node.left = deserializeHelper(nodes);
                node.right = deserializeHelper(nodes);
                return node;
            }
        }
    }

    public static void main(String[] args) {
        Codec codec = new Codec();
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.right.left = new TreeNode(4);
        root.right.right = new TreeNode(5);

        String serialized = codec.serialize(root);
        System.out.println("Serialized: " + serialized);

        TreeNode deserializedRoot = codec.deserialize(serialized);
        String reserialized = codec.serialize(deserializedRoot);
        System.out.println("Reserialized: " + reserialized);
    }
}
