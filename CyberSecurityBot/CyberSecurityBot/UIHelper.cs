using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CyberSecurityBot
{
    

    public static class UIHelper
    {
        public static void ShowHeader()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("========================================");
            Console.WriteLine(" CYBERSECURITY AWARENESS BOT ");
            Console.WriteLine("========================================");
            Console.ResetColor();
        }

        public static void TypeText(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
        }

        public static void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"⚠️ {message}");
            Console.ResetColor();
        }
    }
}
