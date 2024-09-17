import java.util.*;

class TreeNode {
    int val;
    TreeNode left;
    TreeNode right;
    
    TreeNode(int x) { val = x; }
}

public class teste1 {

    // Serialize a tree to a single string
    public String serialize(TreeNode root) {
        if (root == null) {
            return "null";
        }
        
        Queue<TreeNode> queue = new LinkedList<>();
        StringBuilder sb = new StringBuilder();
        
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

    // Deserialize your encoded data to tree
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
        teste1 serializer = new teste1();
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.right.left = new TreeNode(4);
        root.right.right = new TreeNode(5);
        
        String serializedData = serializer.serialize(root);
        System.out.println("Serialized data: " + serializedData);
        
        TreeNode deserializedRoot = serializer.deserialize(serializedData);
        System.out.println("Deserialized tree root value: " + deserializedRoot.val);
    }
}
