using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("123456", "Nokia 3310", "111111", 16);
        nokia.Ligar();
        nokia.InstalarAplicativo("Notas");

        Console.WriteLine();

        Smartphone iphone = new Iphone("987654", "iPhone 14", "222222", 128);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
