using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Hashing
{
    class Hash
    {

        /// <summary>
        /// Computes an SHA1 hash
        /// with text
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static byte[] ComputeSHA1(byte[] text)
        {
            using(var sha1 = SHA1.Create()){
                //char[] newText = Encoding.ASCII.GetChars(sha1.ComputeHash(text));
                //return new string(newText);
                return sha1.ComputeHash(text);
            }
        }

        /// <summary>
        /// Computes an SHA256 hash
        /// with text
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static byte[] ComputeSHA256(byte[] text)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(text);
                
            }
        }

        /// <summary>
        /// Computes an SHA384 hash
        /// with text
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static byte[] ComputeSHA384(byte[] text)
        {
            using (var sha384 = SHA384.Create())
            {
                return sha384.ComputeHash(text);
            }
        }

        /// <summary>
        /// Computes an SHA512 hash
        /// with text
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static byte[] ComputeSHA512(byte[] text)
        {
            using (var sha512 = SHA512.Create())
            {
                return sha512.ComputeHash(text);
            }
        }

        /// <summary>
        /// Compute an MD5 hash
        /// with text
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static byte[] ComputeMD5(byte[] text)
        {
            using (var md5 = MD5.Create())
            {
                return md5.ComputeHash(text);
            }
        }
    }
}
