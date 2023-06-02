using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _01._1_CalculatorWeb.Pages
{
    public class ggtcalculatorModel : PageModel
    {
        public string Result { get; set; }
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public void OnGet(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
            Result = CalculateggT(number1, number2);
        }

        private string CalculateggT(int number1, int number2)
        {
            int rf = 0;

            if (number1 < 0)
            {
                number1 = number1 * (-1);
            }

            while (number2 > 0)
            {
                rf = number1 % number2;
                number1 = number2;
                number2 = rf;
            }

            return number1.ToString();
        }
    }
}
