import java.util.*;

public class teste2 {

    public static class TreeNode {
        int val;
        TreeNode left;
        TreeNode right;
        TreeNode(int x) { val = x; }
    }

    public static class Codec {

        // Encodes a tree to a single string.
        public String serialize(TreeNode root) {
            StringBuilder sb = new StringBuilder();
            serializeHelper(root, sb);
            return sb.toString();
        }

        private void serializeHelper(TreeNode root, StringBuilder sb) {
            if (root == null) {
                sb.append("null,");
            } else {
                sb.append(root.val).append(",");
                serializeHelper(root.left, sb);
                serializeHelper(root.right, sb);
            }
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(String data) {
            String[] dataArray = data.split(",");
            Queue<String> queue = new LinkedList<>(Arrays.asList(dataArray));
            return deserializeHelper(queue);
        }

        private TreeNode deserializeHelper(Queue<String> queue) {
            String val = queue.poll();
            if (val.equals("null")) {
                return null;
            }
            TreeNode root = new TreeNode(Integer.parseInt(val));
            root.left = deserializeHelper(queue);
            root.right = deserializeHelper(queue);
            return root;
        }
    }
    
}
