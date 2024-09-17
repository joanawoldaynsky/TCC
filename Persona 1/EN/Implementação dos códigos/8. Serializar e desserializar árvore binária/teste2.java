import java.util.Arrays;
import java.util.LinkedList;
import java.util.List;

public class teste2 {
    private static final String SEP = ",";
    private static final String NULL = "null";

    public String serialize(TreeNode root) {
        StringBuilder sb = new StringBuilder();
        serialize(root, sb);
        return sb.toString();
    }

    private void serialize(TreeNode root, StringBuilder sb) {
        if (root == null) {
            sb.append(NULL).append(SEP);
            return;
        }
        sb.append(root.val).append(SEP);
        serialize(root.left, sb);
        serialize(root.right, sb);
    }

    public TreeNode deserialize(String data) {
        String[] dataArray = data.split(SEP);
        List<String> dataList = new LinkedList<>(Arrays.asList(dataArray));
        return deserialize(dataList);
    }

    private TreeNode deserialize(List<String> dataList) {
        if (dataList.get(0).equals(NULL)) {
            dataList.remove(0);
            return null;
        }

        TreeNode root = new TreeNode(Integer.parseInt(dataList.remove(0)));
        root.left = deserialize(dataList);
        root.right = deserialize(dataList);
        return root;
    }
}
