import java.util.*;

class TreeNode {
    int val;
    TreeNode left;
    TreeNode right;
    
    TreeNode(int x) {
        val = x;
    }
}

public class teste1 {

    // Serializa a árvore binária em uma string (DFS - Pré-Ordem)
    public String serialize(TreeNode root) {
        if (root == null) {
            return "null";
        }
        
        StringBuilder sb = new StringBuilder();
        serializeHelper(root, sb);
        return sb.toString();
    }
    
    private void serializeHelper(TreeNode root, StringBuilder sb) {
        if (root == null) {
            sb.append("null,");
            return;
        }
        sb.append(root.val).append(",");
        serializeHelper(root.left, sb);
        serializeHelper(root.right, sb);
    }

    // Desserializa a string para a árvore binária (DFS - Pré-Ordem)
    public TreeNode deserialize(String data) {
        String[] nodes = data.split(",");
        Queue<String> queue = new LinkedList<>(Arrays.asList(nodes));
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

    public static void main(String[] args) {
        teste1 bts = new teste1();
        
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.right.left = new TreeNode(4);
        root.right.right = new TreeNode(5);

        String serialized = bts.serialize(root);
        System.out.println("Serialized: " + serialized);

        TreeNode deserializedRoot = bts.deserialize(serialized);
        String deserializedSerialized = bts.serialize(deserializedRoot);
        System.out.println("Deserialized and Serialized again: " + deserializedSerialized);
    }
}
