using System;

namespace RefactorSpecialNumber
{
    public class RefactorSpecialNumber
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            
            for (int ch = 1; ch <= n; ch++)
            {

                int sumofDigits = 0;
                int digits = 0;

                digits = ch;
                while (ch > 0)
                {
                    sumofDigits += ch % 10;
                    ch = ch / 10;
                }
                bool toe = false;
                toe = (sumofDigits == 5) || (sumofDigits == 7) || (sumofDigits == 11);
                Console.WriteLine($"{digits} -> {toe}");
                sumofDigits = 0;
                ch = digits;
            }

        }
    }
}
