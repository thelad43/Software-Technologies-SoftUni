import java.util.Scanner;

public class SumTwoNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Double firstNumber = Double.parseDouble(scanner.nextLine());
        Double secondNumber = Double.parseDouble(scanner.nextLine());
        Double result = firstNumber + secondNumber;
        System.out.println(result);
    }
}