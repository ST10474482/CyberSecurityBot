using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityBot
{
    public static class ResponseHandler
    {
        
        private static HashSet<string> ignoring = new HashSet<string>();

        
        static ResponseHandler()
        {
            ignoring.Add("a");
            ignoring.Add("about");
            ignoring.Add("above");
            ignoring.Add("across");
            ignoring.Add("after");
            ignoring.Add("afterwards");
            ignoring.Add("again");
            ignoring.Add("against");
            ignoring.Add("all");
            ignoring.Add("almost");
            ignoring.Add("alone");
            ignoring.Add("along");
            ignoring.Add("already");
            ignoring.Add("also");
            ignoring.Add("although");
            ignoring.Add("always");
            ignoring.Add("am");
            ignoring.Add("among");
            ignoring.Add("amongst");
            ignoring.Add("amount");
            ignoring.Add("an");
            ignoring.Add("and");
            ignoring.Add("another");
            ignoring.Add("any");
            ignoring.Add("anyone");
            ignoring.Add("anything");
            ignoring.Add("are");
            ignoring.Add("as");
            ignoring.Add("at");
            ignoring.Add("be");
            ignoring.Add("because");
            ignoring.Add("been");
            ignoring.Add("before");
            ignoring.Add("being");
            ignoring.Add("but");
            ignoring.Add("by");
            ignoring.Add("can");
            ignoring.Add("could");
            ignoring.Add("do");
            ignoring.Add("does");
            ignoring.Add("doing");
            ignoring.Add("for");
            ignoring.Add("from");
            ignoring.Add("get");
            ignoring.Add("got");
            ignoring.Add("had");
            ignoring.Add("has");
            ignoring.Add("have");
            ignoring.Add("having");
            ignoring.Add("he");
            ignoring.Add("her");
            ignoring.Add("here");
            ignoring.Add("him");
            ignoring.Add("his");
            ignoring.Add("how");
            ignoring.Add("i");
            ignoring.Add("if");
            ignoring.Add("in");
            ignoring.Add("into");
            ignoring.Add("is");
            ignoring.Add("it");
            ignoring.Add("its");
            ignoring.Add("me");
            ignoring.Add("my");
            ignoring.Add("of");
            ignoring.Add("on");
            ignoring.Add("or");
            ignoring.Add("our");
            ignoring.Add("she");
            ignoring.Add("so");
            ignoring.Add("that");
            ignoring.Add("the");
            ignoring.Add("their");
            ignoring.Add("them");
            ignoring.Add("then");
            ignoring.Add("there");
            ignoring.Add("these");
            ignoring.Add("they");
            ignoring.Add("this");
            ignoring.Add("to");
            ignoring.Add("was");
            ignoring.Add("we");
            ignoring.Add("what");
            ignoring.Add("when");
            ignoring.Add("where");
            ignoring.Add("which");
            ignoring.Add("who");
            ignoring.Add("why");
            ignoring.Add("will");
            ignoring.Add("with");
            ignoring.Add("you");
            ignoring.Add("your");
        }

       
        public static string GetResponse(string input)
        {
            if(input.Contains("password"))
            return "Use strong passwords with symbols and numbers, avoid reusing old passwords, and consider using a password manager.";

            if (input.Contains("phishing"))
                return "Be careful of fake emails asking for personal info, never click suspicious links or attachments, and always verify the sender before responding.";

            if (input.Contains("link"))
                return "Only click trusted links and check HTTPS, verify the website address carefully, and avoid clicking shortened or unknown URLs.";

            if(input.Contains("purpose"))
    return "I help you stay safe from cyber threats by giving security tips, warnings, and best practices for online safety.";

            if(input.Contains("how are you"))
    return "I'm running perfectly and ready to help you with anything you need.";

            if (input.Contains("why"))
                return "Could you please clarify your question so I can help you better?";

            if (input.Contains("help"))
                return "password, phishing, link, purpose";

            return "I didn't quite understand that. Could you rephrase?";
        }
    }
}