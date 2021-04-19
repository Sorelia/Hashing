using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    class SwitchCase
    {
        public static string HashCase(int choice)
        {
            switch (choice)
            {
                case 1:
                    string sha1MSG = Console.ReadLine();
                    var sha1 = Hash.ComputeSHA1(Encoding.UTF8.GetBytes(sha1MSG));
                    return Convert.ToBase64String(sha1);
                case 2:
                    string sha256MSG = Console.ReadLine();
                    var sha256 = Hash.ComputeSHA256(Encoding.UTF8.GetBytes(sha256MSG));
                    return Convert.ToBase64String(sha256);
                case 3:
                    string sha384MSG = Console.ReadLine();
                    var sha384 = Hash.ComputeSHA384(Encoding.UTF8.GetBytes(sha384MSG));
                    return Convert.ToBase64String(sha384);
                case 4:
                    string sha512MSG = Console.ReadLine();
                    var sha512 = Hash.ComputeSHA512(Encoding.UTF8.GetBytes(sha512MSG));
                    return Convert.ToBase64String(sha512);
                case 5:
                    string md5MSG = Console.ReadLine();
                    var md5 = Hash.ComputeMD5(Encoding.UTF8.GetBytes(md5MSG));
                    return Convert.ToBase64String(md5);
            }
            return "Wrong input";
        }

        public static string HmachCase(int choice)
        {
            switch (choice)
            {
                case 1:
                    string sha1MSG = Console.ReadLine();
                    var sha1 = HMAC.ComputeHmachSHA1(Encoding.UTF8.GetBytes(sha1MSG), Key.GenerateKey());
                    return Convert.ToBase64String(sha1);
                case 2:
                    string sha256MSG = Console.ReadLine();
                    var sha256 = HMAC.ComputeHmachSHA256(Encoding.UTF8.GetBytes(sha256MSG), Key.GenerateKey());
                    return Convert.ToBase64String(sha256);
                case 3:
                    string sha384MSG = Console.ReadLine();
                    var sha384 = HMAC.ComputeHmachSHA384(Encoding.UTF8.GetBytes(sha384MSG), Key.GenerateKey());
                    return Convert.ToBase64String(sha384);
                case 4:
                    string sha512MSG = Console.ReadLine();
                    var sha512 = HMAC.ComputeHmachSHA512(Encoding.UTF8.GetBytes(sha512MSG), Key.GenerateKey());
                    return Convert.ToBase64String(sha512);
                case 5:
                    string md5MSG = Console.ReadLine();
                    var md5 = HMAC.ComputeHmacMD5(Encoding.UTF8.GetBytes(md5MSG), Key.GenerateKey());
                    return Convert.ToBase64String(md5);
            }
            return "Wrong input";
        }
    }
}
