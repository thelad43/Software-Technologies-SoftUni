import java.util.Arrays;
import java.util.Scanner;

public class ThreeIntegersSum {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] numbers = Arrays.stream(scanner.nextLine().split("\\s+"))
                .mapToInt(Integer::parseInt)
                .toArray();

        Integer firstNumber = numbers[0];
        Integer secondNumber = numbers[1];
        Integer thirdNumber = numbers[2];

        if (firstNumber + secondNumber == thirdNumber) {
            System.out.printf("%d + %d = %d%n", Math.min(firstNumber, secondNumber), Math.max(secondNumber, firstNumber), thirdNumber);
        } else if (secondNumber + thirdNumber == firstNumber) {
            System.out.printf("%d + %d = %d%n", Math.min(thirdNumber, secondNumber), Math.max(secondNumber, thirdNumber), firstNumber);
        } else if (firstNumber + thirdNumber == secondNumber) {
            System.out.printf("%d + %d = %d%n", Math.min(thirdNumber, firstNumber), Math.max(thirdNumber, firstNumber), secondNumber);
        } else {
            System.out.println("No");
        }
    }
}