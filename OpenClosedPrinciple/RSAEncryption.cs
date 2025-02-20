using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class RSAEncryption : IEncryption
    {
        public string Encrypt(string input)
        {
            return $"{input} is now RSA Encrypted";
        }
    }
}
