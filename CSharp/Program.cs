namespace Bin2Dec
{
    class Principal
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Binary to Decimal converter");
                Console.Write("Enter your binary: ");
                string binaryNumber = Console.ReadLine()!;

                if(string.IsNullOrEmpty(binaryNumber) || string.IsNullOrWhiteSpace(binaryNumber))
                {
                    Console.WriteLine("No blank spaces allowed");
                    continue;
                }

                try
                {
                    if(IsNumberBinary(binaryNumber))
                    {
                        if(!HasMoreThanEightDigits(binaryNumber))
                        {                    
                        Console.WriteLine($"Binary: {binaryNumber} | Decimal:{ConvertToDecimal(binaryNumber)}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not a binary number, please try again");
                        continue;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                    continue;
                }
                
                Console.WriteLine("Convert another binary to decimal? (Y/N)");
                string op = Console.ReadLine()!.ToUpper();

                if(op == "Y")
                {
                    continue;
                }
                else if(op == "N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }
        }

        private static bool HasMoreThanEightDigits(string number)
        {
            return number.Length > 8;
        }

        private static bool IsNumberBinary(string number)
        {
            return int.Parse(number) < 2 && int.Parse(number) >= 0;
        }

        private static int ConvertToDecimal(string number)
        {
            int nLength = number.Length;
            string numberReverse = new string(number.Reverse().ToArray());
            double dec = 0;

            for(int i = 0; i < nLength; i++)
            {
                double n = int.Parse(numberReverse[i].ToString());
                dec += n * Math.Pow(2, i);
            }

            return int.Parse(dec.ToString());
        }
    }
}