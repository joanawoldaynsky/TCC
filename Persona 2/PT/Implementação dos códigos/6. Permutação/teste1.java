import java.util.ArrayList;
import java.util.List;

public class teste1 {

    public static void main(String[] args) {
        String str = "ABC";
        List<String> resultado = new ArrayList<>();
        permutar(str, "", resultado);
        for (String s : resultado) {
            System.out.println(s);
        }
    }

    private static void permutar(String str, String prefixo, List<String> resultado) {
        if (str.length() == 0) {
            resultado.add(prefixo);
        } else {
            for (int i = 0; i < str.length(); i++) {
                permutar(str.substring(0, i) + str.substring(i + 1), prefixo + str.charAt(i), resultado);
            }
        }
    }
}
