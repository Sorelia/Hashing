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
            
            while (i == 1){
                Console.WriteLine("Select your choice, Write the number\r\n 1) Hash 2) Hash with Hmac 3) Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Choose your hash, Write the number\r\n 1) sha1 2) sha256 3) sha384 4) sha512 5) MD5");
                        choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {

                            case 1:
                                Console.WriteLine("Write your msg");
                                string sha1MSG = Console.ReadLine();
                                Console.WriteLine("encoding");
                                var sha1 = Hash.ComputeSHA1(Encoding.UTF8.GetBytes(sha1MSG));
                                Console.WriteLine("SHA1 Hash: " + Convert.ToBase64String(sha1));
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.WriteLine("Write your msg");
                                string sha256MSG = Console.ReadLine();
                                Console.WriteLine("encoding");
                                var sha256 = Hash.ComputeSHA256(Encoding.UTF8.GetBytes(sha256MSG));
                                Console.WriteLine("SHA256 Hash: " + Convert.ToBase64String(sha256));
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.WriteLine("Write your msg");
                                string sha384MSG = Console.ReadLine();
                                Console.WriteLine("encoding");
                                var sha384 = Hash.ComputeSHA384(Encoding.UTF8.GetBytes(sha384MSG));
                                Console.WriteLine("SHA384 Hash: " + Convert.ToBase64String(sha384));
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.WriteLine("Write your msg");
                                string sha512MSG = Console.ReadLine();
                                Console.WriteLine("encoding");
                                var sha512 = Hash.ComputeSHA512(Encoding.UTF8.GetBytes(sha512MSG));
                                Console.WriteLine("SHA512 Hash: " + Convert.ToBase64String(sha512));
                                Console.ReadKey();
                                break;
                            case 5:
                                Console.WriteLine("Write your msg");
                                string md5MSG = Console.ReadLine();
                                Console.WriteLine("encoding");
                                var md5 = Hash.ComputeMD5(Encoding.UTF8.GetBytes(md5MSG));
                                Console.WriteLine("MD5 Hash: " + Convert.ToBase64String(md5));
                                Console.ReadKey();
                                break;
                        }

                        break;
                    case 2:
                        Console.WriteLine("Choose your Hmac hash, Write the number\r\n 1) sha1 2) sha256 3) sha384 4) sha512 5) MD5");
                        choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {

                            case 1:
                                Console.WriteLine("Write your msg");
                                string sha1MSG = Console.ReadLine();
                                Console.WriteLine("encoding");
                                var sha1 = HMAC.ComputeHmachSHA1(Encoding.UTF8.GetBytes(sha1MSG), Key.GenerateKey());
                                Console.WriteLine("SHA1 Hash: " + Convert.ToBase64String(sha1));
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.WriteLine("Write your msg");
                                string sha256MSG = Console.ReadLine();
                                Console.WriteLine("encoding");
                                var sha256 = HMAC.ComputeHmachSHA256(Encoding.UTF8.GetBytes(sha256MSG), Key.GenerateKey());
                                Console.WriteLine("SHA256 Hash: " + Convert.ToBase64String(sha256));
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.WriteLine("Write your msg");
                                string sha384MSG = Console.ReadLine();
                                Console.WriteLine("encoding");
                                var sha384 = HMAC.ComputeHmachSHA384(Encoding.UTF8.GetBytes(sha384MSG), Key.GenerateKey());
                                Console.WriteLine("SHA384 Hash: " + Convert.ToBase64String(sha384));
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.WriteLine("Write your msg");
                                string sha512MSG = Console.ReadLine();
                                Console.WriteLine("encoding");
                                var sha512 = HMAC.ComputeHmachSHA512(Encoding.UTF8.GetBytes(sha512MSG), Key.GenerateKey());
                                Console.WriteLine("SHA512 Hash: " + Convert.ToBase64String(sha512));
                                Console.ReadKey();
                                break;
                            case 5:
                                Console.WriteLine("Write your msg");
                                string md5MSG = Console.ReadLine();
                                Console.WriteLine("encoding");
                                var md5 = HMAC.ComputeHmacMD5(Encoding.UTF8.GetBytes(md5MSG),Key.GenerateKey());
                                Console.WriteLine("MD5 Hash: " + Convert.ToBase64String(md5));
                                Console.ReadKey();
                                break;
                        }

                        break;
                    case 3:
                        i = 0;
                        break;
                }
                    
            }
        }
    }
}
