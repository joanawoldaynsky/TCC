import java.util.LinkedList;
import java.util.Queue;

public class teste3 {
    public static class TreeNode {
        int val;
        TreeNode left;
        TreeNode right;
        TreeNode(int x) { val = x; }
    }

    public static class Codec {
        // Encodes a tree to a single string.
        public String serialize(TreeNode root) {
            if (root == null) return "";
            StringBuilder sb = new StringBuilder();
            Queue<TreeNode> queue = new LinkedList<>();
            queue.add(root);

            while (!queue.isEmpty()) {
                TreeNode node = queue.poll();
                if (node != null) {
                    sb.append(node.val).append(",");
                    queue.add(node.left);
                    queue.add(node.right);
                } else {
                    sb.append("null,");
                }
            }
            sb.setLength(sb.length() - 1); // Remove last comma
            return sb.toString();
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(String data) {
            if (data.isEmpty()) return null;
            String[] nodes = data.split(",");
            TreeNode root = new TreeNode(Integer.parseInt(nodes[0]));
            Queue<TreeNode> queue = new LinkedList<>();
            queue.add(root);
            int i = 1;

            while (!queue.isEmpty()) {
                TreeNode node = queue.poll();
                if (!nodes[i].equals("null")) {
                    node.left = new TreeNode(Integer.parseInt(nodes[i]));
                    queue.add(node.left);
                }
                i++;
                if (!nodes[i].equals("null")) {
                    node.right = new TreeNode(Integer.parseInt(nodes[i]));
                    queue.add(node.right);
                }
                i++;
            }
            return root;
        }
    }
}