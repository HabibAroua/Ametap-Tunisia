using System;
using System.Text.RegularExpressions;

namespace AMETAP.View.Script
{
    public class RegularExpression
    {
        public RegularExpression()
        {}

        public Boolean VerifMail(String email)
        {
            bool isTrue = false;
            Regex r = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (r.IsMatch(email))
            {
                isTrue = true;
            }
            return isTrue;
        }
    }
}
