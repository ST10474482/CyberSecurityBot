using System;
using System.Drawing;
using System.IO;

namespace CyberSecurityBot
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Cybersecurity Awareness Bot";

            
            AsciiArt();

           
            var bot = new Chatbot();
            bot.Start();
        }

        static void AsciiArt()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "logo.jpg");

            if (!File.Exists(path))
            {
                Console.WriteLine("Image file not found!");
                return;
            }

            using Bitmap image = new Bitmap(path);

            int newWidth = 150;
            int newHeight = (int)(image.Height / (double)image.Width * newWidth * 0.5);
            using Bitmap resized = new Bitmap(image, new Size(newWidth, newHeight));

            string asciiChars = "@#S%?*+;:,. ";

            Console.Clear();
            int padLeft = (Console.WindowWidth - newWidth) / 2;

            for (int y = 0; y < resized.Height; y++)
            {
                Console.Write(new string(' ', Math.Max(padLeft, 0)));
                for (int x = 0; x < resized.Width; x++)
                {
                    Color pixel = resized.GetPixel(x, y);
                    int gray = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
                    int index = gray * (asciiChars.Length - 1) / 255;
                    Console.Write(asciiChars[index]);
                }
                Console.WriteLine();
            }
        }
    }
}