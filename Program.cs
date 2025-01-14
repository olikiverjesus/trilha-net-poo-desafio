using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Testando a classe Nokia
            Console.WriteLine("Teste com Nokia:");
            Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 32);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            // Testando a classe iPhone
            Console.WriteLine("Teste com iPhone:");
            Smartphone iphone = new Iphone("987654321", "iPhone 12", "987654321098765", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.WriteLine();
        }
    }
}
