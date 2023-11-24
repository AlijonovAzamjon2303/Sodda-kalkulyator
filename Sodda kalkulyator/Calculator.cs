

namespace Sodda_kalkulyator
{
    internal class Calculator
    {
        public static double Calculate(string nums)
        {
            double natija = 0;
            string[] s = nums.Split();
            if (s.Length != 3)
            {
                Console.WriteLine("O'zgaruvchilar kutilgan sonda emas!");
                return 0;
            }
            double x = 0, y = 0;
            try
            {
                x = double.Parse(s[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (!(s[1] == "+" || s[1] == "-" || s[1] == "/" || s[1] == "*"))
            {
                Console.WriteLine("Amallardan birini tanlang : +, -, *, / ");
                return 0 ;
            }
            try
            {
                y = double.Parse(s[2]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            switch (s[1])
            {
                case "+": natija = x + y; break;
                case "-": natija = x - y; break;
                case "*": natija = x * y; break;
                case "/":
                    {
                        try
                        {
                            natija = x / y;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    break;
            }
            return natija;
        }
    }
}
