using System;
using System.Security.Cryptography;
using System.Text;

namespace hretska
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to hash: ");
            byte[] a = Encoding.UTF8.GetBytes(Console.ReadLine());
            Console.WriteLine("Enter password for HMAC: ");
            byte[] b = Encoding.UTF8.GetBytes(Console.ReadLine());
            byte[] hmac = ComputeHmacsha512(a, b);
            Console.WriteLine("HMAC: " + Encoding.UTF8.GetString(hmac));
        }
        public static byte[] ComputeHmacsha512(byte[] toBeHashed, byte[] key)
        {
            using (var hmac = new HMACSHA512(key))
            {
                return hmac.ComputeHash(toBeHashed);
            }
        }
    }
}