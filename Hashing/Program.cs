using System;
using System.Text;

namespace Hashing
{
    class Program
    {

        private static int choice;
        static void Main(string[] args)
        {
            int i = 1;
            // looping while you havent decided to exit
            while (i == 1){
                Console.WriteLine("Select your choice, Write the number\r\n 1) Hash 2) Hash with Hmac 3) Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                //Switch case upon your first choice
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Choose your hash, Write the number\r\n 1) sha1 2) sha256 3) sha384 4) sha512 5) MD5");
                        choice = Convert.ToInt32(Console.ReadLine());
                        //switch case upon your second choice
                        Console.WriteLine("Write your msg");
                        string text = SwitchCase.HashCase(choice);
                        Console.WriteLine("encoding");
                        Console.WriteLine(text);
                        break;
                    case 2:
                        Console.WriteLine("Choose your Hmac hash, Write the number\r\n 1) sha1 2) sha256 3) sha384 4) sha512 5) MD5");
                        choice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Write your msg");
                        Console.WriteLine("encoding");
                        text = SwitchCase.HmachCase(choice);
                        Console.WriteLine(text); 
                        break;
                    case 3:
                        i = 0;
                        Console.WriteLine(@"G'night");
                        break;
                }   
            }
        }
    }
}
