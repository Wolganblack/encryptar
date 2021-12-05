using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace encryptar_datos
{
   public class Clave
    {
        internal object username;
        internal string password;

        public Clave(object username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public static string GetSHA256(string str) { 
        SHA256 sha256 = SHA256Managed.Create();
        ASCIIEncoding encoding = new ASCIIEncoding();
        byte[] stream = null;
        StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
        for (int i= 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();

                }
    }
}
