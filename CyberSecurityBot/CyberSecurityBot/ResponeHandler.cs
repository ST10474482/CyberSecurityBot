using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityBot
{
    public static class ResponseHandler
    {
        public static string GetResponse(string input)
        {
            if (input.Contains("password"))
                return "Use strong passwords with symbols and numbers ";

            if (input.Contains("phishing"))
                return "Be careful of fake emails asking for personal info ";

            if (input.Contains("link"))
                return "Only click trusted links and check HTTPS ";

            if (input.Contains("purpose"))
                return "I help you stay safe from cyber threats ";

            if (input.Contains("how are you"))
                return "I'm running perfectly and ready to help ";

            if (input.Contains("why"))
                return "What you wrote doesn't make sense ";

            if (input.Contains("help"))
                return "password, phishing, link, purpose";

            return "I didn't quite understand that. Could you rephrase?";
        }
    }
}
