using System;

namespace procesare_caractere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numele fisierului dorit:");
            Procesare procesare = new Procesare();
            Console.WriteLine("In fisierul ales sunt: {0} vocale.", procesare.Vocale);
            Console.WriteLine("In fisierul ales sunt: {0} consoane.", procesare.Consoane);
            Console.WriteLine("In fisierul ales sunt: {0} linii.", procesare.Linii);
            Console.WriteLine("In fisierul ales sunt: {0} caractere.", procesare.Total);

        }
    }
}
