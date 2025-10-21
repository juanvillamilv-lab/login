using System;
using System.Security.Cryptography;
using System.Text;
using Auth;
using DomainEntities;

namespace serv
{
    public class AuthServImpl : IAuth
    {
        private static readonly byte[] key = Encoding.UTF8.GetBytes("12345678901234567890123456789012"); // 32 bytes = 256 bits
        private static readonly byte[] iv  = Encoding.UTF8.GetBytes("1234567890123456");

        // Encrypt password using AES-256-CBC
        public string EncryptPassword(string password)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = aes.CreateEncryptor();
                byte[] plainBytes = Encoding.UTF8.GetBytes(password);
                byte[] cipherBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);

                return Convert.ToBase64String(cipherBytes);
            }
        }

        // Decrypt password using AES-256-CBC
        public string DecryptPassword(string encryptedPassword)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                ICryptoTransform decryptor = aes.CreateDecryptor();
                byte[] cipherBytes = Convert.FromBase64String(encryptedPassword);
                byte[] plainBytes = decryptor.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);

                return Encoding.UTF8.GetString(plainBytes);
            }
        }

        public void RegistrarUsuario(DomainAuth adapterAuth)
        {

        }
        
        public void IniciarSesionUsuario(DomainAuth adapterAuth)
        {

        }
        
        public void CambiarContraseña(string usuario, string contraseña)
        {
            
        }

    }
}
