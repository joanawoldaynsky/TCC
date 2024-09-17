import java.util.*;

public class teste3 {
    public static class TreeNode {
        int val;
        TreeNode left;
        TreeNode right;
    
        TreeNode(int x) { val = x; }
    }
    public static class Codec {
        // Serializa uma árvore binária em uma string.
        public String serialize(TreeNode root) {
            if (root == null) return "";
            Queue<TreeNode> queue = new LinkedList<>();
            queue.add(root);
            StringBuilder sb = new StringBuilder();
            while (!queue.isEmpty()) {
                TreeNode node = queue.poll();
                if (node == null) {
                    sb.append("null,");
                } else {
                    sb.append(node.val).append(",");
                    queue.add(node.left);
                    queue.add(node.right);
                }
            }
            return sb.toString();
        }
    
        // Desserializa a string de volta em uma árvore binária.
        public TreeNode deserialize(String data) {
            Queue<String> nodes = new LinkedList<>(Arrays.asList(data.split(",")));
            return deserializeHelper(nodes);
        }
    
        private TreeNode deserializeHelper(Queue<String> nodes) {
            String val = nodes.poll();
            if (val.equals("null")) return null;
            TreeNode root = new TreeNode(Integer.parseInt(val));
            root.left = deserializeHelper(nodes);
            root.right = deserializeHelper(nodes);
            return root;
        }
    
        public static void main(String[] args) {
            Codec codec = new Codec();
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
    
            String serialized = codec.serialize(root);
            System.out.println("Serialized: " + serialized);
    
            TreeNode deserialized = codec.deserialize(serialized);
            System.out.println("Deserialized Root: " + deserialized.val);
        }
    }
}
