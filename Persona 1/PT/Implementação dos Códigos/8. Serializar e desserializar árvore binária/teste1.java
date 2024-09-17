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

    // Serializa a árvore binária em uma string
    public String serialize(TreeNode root) {
        if (root == null) {
            return "null";
        }
        
        Queue<TreeNode> queue = new LinkedList<>();
        queue.add(root);
        StringBuilder sb = new StringBuilder();
        
        while (!queue.isEmpty()) {
            TreeNode node = queue.poll();
            if (node == null) {
                sb.append("null,");
                continue;
            }
            sb.append(node.val).append(",");
            queue.add(node.left);
            queue.add(node.right);
        }
        
        return sb.toString();
    }

    // Desserializa a string para a árvore binária
    public TreeNode deserialize(String data) {
        if (data.equals("null")) {
            return null;
        }
        
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

    public static void main(String[] args) {
        BinaryTreeSerialization bts = new BinaryTreeSerialization();
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
