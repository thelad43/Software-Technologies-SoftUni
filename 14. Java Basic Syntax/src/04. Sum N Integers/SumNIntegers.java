import java.util.Scanner;

public class SumNIntegers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Integer number = Integer.parseInt(scanner.nextLine());
        Integer sum = 0;

        for (int i = 0; i < number; i++) {
            sum += Integer.parseInt(scanner.nextLine());
        }

        System.out.println(sum);
    }
}