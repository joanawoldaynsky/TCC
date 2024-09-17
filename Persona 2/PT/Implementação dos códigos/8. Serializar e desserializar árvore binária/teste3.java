import java.util.*;

class TreeNode {
    int val;
    TreeNode left;
    TreeNode right;
    TreeNode(int x) { val = x; }
}

public class teste3 {

    // Serializes a tree to a single string.
    public String serialize(TreeNode root) {
        if (root == null) return "X";
        String leftSerialized = serialize(root.left);
        String rightSerialized = serialize(root.right);
        return root.val + "," + leftSerialized + "," + rightSerialized;
    }

    // Deserializes your encoded data to tree.
    public TreeNode deserialize(String data) {
        Queue<String> nodes = new LinkedList<>(Arrays.asList(data.split(",")));
        return buildTree(nodes);
    }

    private TreeNode buildTree(Queue<String> nodes) {
        String val = nodes.poll();
        if (val.equals("X")) return null;
        TreeNode node = new TreeNode(Integer.parseInt(val));
        node.left = buildTree(nodes);
        node.right = buildTree(nodes);
        return node;
    }
}
