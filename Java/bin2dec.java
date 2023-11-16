package Java;

import java.util.Scanner;

public class bin2dec {
        public static void main(String[] args) {
            boolean isRunning = true;
            
            while (isRunning) {
                Scanner scan = new Scanner(System.in);

                System.out.print("Type you binary number: ");
                String number = scan.nextLine();

                try 
                {
                    if(number.length() > 8)
                    {
                        System.out.println("Binary must have less than 8 digits, try again");
                        continue;
                    }
                    
                    if(HasChar(number) == false)
                    {
                        System.out.println("Not a binary number, try again");
                        continue;
                    }

                    System.out.println("Binary: " + number + "| Decimal: " + ConvertBinaryToDecimal(number));

                    Scanner scanAgain = new Scanner(System.in);
                    System.out.print("Convert another binary to decimal? (Y/N): ");
                    String op = scanAgain.nextLine().toUpperCase();

                    switch (op) {
                        case "Y":
                            continue;
                        case "N":
                            isRunning = false;;
                        default:
                            isRunning = false;;
                    }
                } 
                catch (Exception e) 
                {
                    System.out.println("Error: " + e.getMessage());
                    continue;
                }
            }
        }

        private static boolean HasChar(String str)
        {
            char[] number = str.toCharArray();
            int errorCount = 0;

            for(char c : number)
            {
                int n = c - '0';

                if(n > 1 || n < 0)
                {
                    errorCount++;
                }
            }

            return errorCount == 0;
        }

        private static int ConvertBinaryToDecimal(String number)
        {
            int size = number.length();
            double dec = 0.0f;

            String sb = new StringBuilder(number).reverse().toString();

            char[] reverseNumber = sb.toCharArray();

            for(int i = 0; i < size; i++)
            {
                int n = reverseNumber[i] - '0';

                dec += Math.pow(2, i) * n;
            }

            int decimalNumber = (int) dec;

            return decimalNumber;
        }
}