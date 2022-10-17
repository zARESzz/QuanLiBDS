using System;
using System.IO;
using System.Security.Cryptography;

namespace Main
{
    public class cls_MatKhau
    {
        private byte[] key;
        private byte[] iv;
        TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider();
        public cls_MatKhau()
        {
            key = System.Text.UnicodeEncoding.UTF8.GetBytes("1/3*45#hgk&^$!o:u7)(^g-+");
            iv = System.Text.UnicodeEncoding.UTF8.GetBytes("qwe%_=@?");
        }
        public cls_MatKhau(string _key, string _iv)
        {
            key = System.Text.UnicodeEncoding.UTF8.GetBytes(_key);
            iv = System.Text.UnicodeEncoding.UTF8.GetBytes(_iv);
        }
        public string MaHoa(string mk)
        {
            byte[] input = System.Text.UnicodeEncoding.UTF8.GetBytes(mk);
            MemoryStream output = new MemoryStream();
            CryptoStream obj = new CryptoStream(output, DES.CreateEncryptor(key, iv), CryptoStreamMode.Write);
            obj.Write(input, 0, input.Length);
            obj.FlushFinalBlock();
            return Convert.ToBase64String(output.ToArray());
        }
        public string GiaiMa(string mk)
        {
            byte[] input = Convert.FromBase64String(mk);
            MemoryStream output = new MemoryStream();
            CryptoStream obj = new CryptoStream(output, DES.CreateDecryptor(key,iv), CryptoStreamMode.Write);
            obj.Write(input, 0, input.Length);
            obj.FlushFinalBlock();
            return System.Text.UnicodeEncoding.UTF8.GetString(output.ToArray());
        }
    }
}
