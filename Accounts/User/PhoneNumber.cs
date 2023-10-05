using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Accounts.User
{
    public class PhoneNumber
    {
        public string Number { get; init; }

        private const string phoneRegExp = "+[1-9][0-9]{7,14}";

        public PhoneNumber(string phone)
        {
            if (Regex.IsMatch(phone, phoneRegExp) == false)
            {
                throw new ArgumentException("UnvalidNumber");
            }
            Number = phone;
        }

    }
}
