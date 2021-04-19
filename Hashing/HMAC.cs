using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Hashing
{
    class HMAC
    {
        /// <summary>
        /// Computes an HMAC SHA 1 hash
        /// with text and a key
        /// </summary>
        /// <param name="text"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static byte[] ComputeHmachSHA1(byte[] text, byte[] key)
        {
            using (var hmac = new HMACSHA1(key))
            {
                return hmac.ComputeHash(text);
            }
        }

        /// <summary>
        /// computes an HMAC SHA 256 hash
        /// with text and a key
        /// </summary>
        /// <param name="text"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static byte[] ComputeHmachSHA256(byte[] text, byte[] key)
        {
            using (var hmac = new HMACSHA256(key))
            {
                return hmac.ComputeHash(text);
            }
        }

        /// <summary>
        /// Computes an HMAC SHA 384 hash
        /// with text and key
        /// </summary>
        /// <param name="text"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static byte[] ComputeHmachSHA384(byte[] text, byte[] key)
        {
            using (var hmac = new HMACSHA384(key))
            {
                return hmac.ComputeHash(text);
            }
        }

        /// <summary>
        /// Computes an HMAC SHA 512 hash
        /// with text and key
        /// </summary>
        /// <param name="text"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static byte[] ComputeHmachSHA512(byte[] text, byte[] key)
        {
            using (var hmac = new HMACSHA512(key))
            {
                return hmac.ComputeHash(text);
            }
        }


        /// <summary>
        /// Compute an HMAC MD5 hash
        /// with text and key
        /// </summary>
        /// <param name="text"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static byte[] ComputeHmacMD5(byte[] text, byte[] key)
        {
            using (var hmac = new HMACMD5(key))
            {
                return hmac.ComputeHash(text);
            }
        }
    }
}
