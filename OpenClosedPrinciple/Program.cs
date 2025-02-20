using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEncryption AesEncrypt = new AESEncryption();
            string encryptedWithAes = AesEncrypt.Encrypt("PASSWORD");
            Console.WriteLine(encryptedWithAes);

            IEncryption RsaEncrypt = new RSAEncryption();
            string encryptedWithRsa = RsaEncrypt.Encrypt("PASSWORD");
            Console.WriteLine(encryptedWithRsa);
        }
    }
}
