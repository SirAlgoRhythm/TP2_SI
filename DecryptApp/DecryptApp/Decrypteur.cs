using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DecryptApp
{
    internal class Decrypteur
    {
        private string hash = String.Empty;
        public bool estDecrypter = false;

        public Decrypteur(string hash)
        {
            this.hash = hash;
        }

        public bool Decripter(string motDict)
        {
            string resultat = String.Empty;
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(motDict));

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    builder.Append(data[i].ToString("x2"));
                }

                resultat = builder.ToString();

                if (resultat == hash)
                {
                    estDecrypter = true;
                }
            }
            return estDecrypter;
        }
    }
}
