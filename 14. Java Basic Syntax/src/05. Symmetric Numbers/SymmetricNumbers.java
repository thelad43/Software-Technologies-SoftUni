import java.util.Scanner;

public class SymmetricNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        StringBuilder sb = new StringBuilder();
        Integer number = scanner.nextInt();

        for (int i = 1; i <= number; i++) {
            if (isSymmetric(i)) {
                sb.append(i);
                sb.append(" ");
            }
        }

        System.out.println(sb.toString().trim());
    }

    private static boolean isSymmetric(int i) {
        char[] chars = Integer.toString(i).toCharArray();

        for (int j = 0; j <= chars.length / 2; j++) {
            if (chars[j] != chars[chars.length - 1 - j]) {
                return false;
            }
        }

        return true;
    }
}