namespace RomanToArabic
{
    public class RomanToArabic
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Podaj liczbe w systemie rzymskim np XII");
            string? roman = Console.ReadLine();
            if (!String.IsNullOrEmpty(roman) )
            {
               Console.WriteLine(TranslateRomanToArabic(roman));
            }
        }

        public static int TranslateRomanToArabic(string roman)
        {
            Dictionary<char, int> RomanNumbers = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D',  500},
                {'M', 1000}
            };
            Stack<int> stack = new Stack<int>();
            foreach (var romanSymbole  in roman.ToUpper())
            {
                if (stack.Count == 0)
                {
                    stack.Push(RomanNumbers[romanSymbole]);
                }
                else if (stack.Peek() >= RomanNumbers[romanSymbole])
                {
                    stack.Push(RomanNumbers[romanSymbole]);
                }
                else
                {
                    var minus = stack.Peek();
                    stack.Pop();
                    stack.Push(RomanNumbers[romanSymbole]-minus);
                }
            } 
            return stack.Sum();
        }
    }
}
