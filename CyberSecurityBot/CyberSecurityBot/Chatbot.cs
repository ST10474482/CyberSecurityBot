using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityBot
{
    

    public class Chatbot
    {
        private string userName;

        public void Start()
        {
            AudioPlayer.PlayGreeting();
            UIHelper.ShowHeader();

            userName = GetUserName();

            UIHelper.TypeText($"Hello {userName}!");
            RunChat();
        }

        private string GetUserName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                UIHelper.ShowError("Name cannot be empty.");
                name = Console.ReadLine();
            }

            return name;
        }

        private void RunChat()
        {
            while (true)
            {
                Console.Write($"\n{userName}: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    UIHelper.ShowError("Please enter a valid question.");
                    continue;
                }

                input = input.ToLower();

                if (input == "exit"
                {
                    UIHelper.TypeText($"Goodbye, {userName}! Stay safe online ");
                    break;
                }

                string response = ResponseHandler.GetResponse(input);
                UIHelper.TypeText(response);
            }
        }
    }
}
