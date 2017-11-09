using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.recruitment
{
    public class InputValidator
    {
        public static void Validate(string[] args)
        {
            CheckInputLength(args);
            CheckInputOrder(args);
        }

        public static void CheckInputLength (string [] args)
        {
            int correctParamsNum = 2;

            if (args.Length != correctParamsNum)
            {
                throw new ArgumentsNumberException();
            }
        }

        public static void CheckInputOrder (string [] args)
        {
            args[0].TryParseToLocalDate(out DateTime startDate);
            args[1].TryParseToLocalDate(out DateTime endDate);
            if (startDate > endDate)
            {
                throw new ArgumentsOrderException();
            }
        }
    }
}
