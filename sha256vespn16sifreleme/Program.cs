using System;
using System.Security.Cryptography;

namespace sha256vespn16sifreleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Şifrelenecek Metni Girin: ");
            string sifrelenecek = Console.ReadLine();
            SHA256Managed sha256 = new SHA256Managed();
            byte[] bitDizisi = System.Text.Encoding.UTF8.GetBytes(sifrelenecek);
            string sifreliVeri = Convert.ToBase64String(sha256.ComputeHash(bitDizisi));
            Console.WriteLine("Girdiğiniz Metnin Şifreli Hali: " + sifreliVeri);
            
        }
    }
}
