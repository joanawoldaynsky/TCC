import java.util.LinkedList;
import java.util.Queue;

public class teste2 {

    // Definição da classe TreeNode
    public static class TreeNode {
        int val;
        TreeNode left;
        TreeNode right;

        TreeNode(int val) {
            this.val = val;
            this.left = null;
            this.right = null;
        }
    }

    // Classe para serializar e desserializar a árvore
    public static class Codec {

        // Serializa a árvore em uma string
        public String serialize(TreeNode root) {
            if (root == null) {
                return "";
            }
            StringBuilder sb = new StringBuilder();
            Queue<TreeNode> queue = new LinkedList<>();
            queue.add(root);

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

        // Desserializa a string de volta em uma árvore
        public TreeNode deserialize(String data) {
            if (data.isEmpty()) {
                return null;
            }
            String[] nodes = data.split(",");
            TreeNode root = new TreeNode(Integer.parseInt(nodes[0]));
            Queue<TreeNode> queue = new LinkedList<>();
            queue.add(root);
            int i = 1;

            while (!queue.isEmpty() && i < nodes.length) {
                TreeNode node = queue.poll();
                if (!nodes[i].equals("null")) {
                    node.left = new TreeNode(Integer.parseInt(nodes[i]));
                    queue.add(node.left);
                }
                i++;
                if (i < nodes.length && !nodes[i].equals("null")) {
                    node.right = new TreeNode(Integer.parseInt(nodes[i]));
                    queue.add(node.right);
                }
                i++;
            }
            return root;
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

        TreeNode deserialized = codec.deserialize(serialized);
        System.out.println("Deserialized: " + codec.serialize(deserialized));
    }
}
