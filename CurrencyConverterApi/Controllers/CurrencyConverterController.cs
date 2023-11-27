using Microsoft.AspNetCore.Mvc;
using System;

namespace CurrencyConverterApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyConverterController : ControllerBase
    {
        [HttpGet("convertToWords")]
        public ActionResult<string> ConvertToWords(string amountStr)
        {
            // Replacement commas with periods to ensure correct parsing
            decimal amount;
            if (!decimal.TryParse(amountStr.Replace(",", "."), out amount) || amount < 0 || amount > 999999999999999.99m)
            {
                return BadRequest("Invalid amount. Please provide a value between 0 and 999,999,999,999,999.99");
            }

            // Extraction of trillions, billions, millions, thousands, dollars, and cents from the input amount
            long trillions = (long)Math.Floor(amount / 1000000000000);
            long billions = (long)Math.Floor((amount - trillions * 1000000000000) / 1000000000);
            long millions = (long)Math.Floor((amount - trillions * 1000000000000 - billions * 1000000000) / 1000000);
            long thousands = (long)Math.Floor((amount - trillions * 1000000000000 - billions * 1000000000 - millions * 1000000) / 1000);
            long dollars = (long)(amount - trillions * 1000000000000 - billions * 1000000000 - millions * 1000000 - thousands * 1000);
            int cents = (int)((amount - trillions * 1000000000000 - billions * 1000000000 - millions * 1000000 - thousands * 1000 - dollars) * 100);

            // Handling excess cents
            if (cents > 99)
            {
                dollars += cents / 100;
                cents %= 100;
            }

            string result = "";

            // Conversion trillions, billions, millions, thousands, dollars, and cents to words
            if (trillions > 0)
            {
                result += $"{NumberToWords(trillions)} trillion ";
            }

            if (billions > 0)
            {
                result += $"{NumberToWords(billions)} billion ";
            }

            if (millions > 0)
            {
                result += $"{NumberToWords(millions)} million ";
            }

            if (thousands > 0)
            {
                result += $"{NumberToWords(thousands)} thousand ";
            }

            if (trillions == 0 && billions == 0 && millions == 0 && thousands == 0 && dollars == 0 && cents == 0)
            {
                return "zero dollars";
            }


            if (dollars > 0 || thousands > 0 || millions > 0 || billions > 0 || trillions > 0)
            {
                result += $"{NumberToWords(dollars)} dollars";
            }

            if (cents > 0)
            {
                if (dollars > 0)
                {
                    result += " and ";
                }
                else
                {
                    result += "zero dollars and ";
                }

                result += $"{NumberToWords(cents)} cents";
            }

            return result.Trim();
        }

        // Conversion a number to words
        private string NumberToWords(long number)
        {
            if (number == 0)
            {
                return "zero";
            }

            string[] units = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] teens = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            string words = "";

            // Conversion hundreds
            if ((number / 100) > 0)
            {
                words += units[number / 100] + " hundred ";
                number %= 100;
            }

            // Conversion tens and ones
            if (number > 0)
            {
                if (words != "")
                {
                    words += "and ";
                }

                if (number < 10)
                {
                    words += units[number];
                }
                else if (number < 20 && number > 10)
                {
                    words += teens[number - 11];
                }
                else
                {
                    words += tens[number / 10];
                    if ((number % 10) > 0)
                    {
                        words += "-" + units[number % 10];
                    }
                }
            }

            return words;
        }
    }
}