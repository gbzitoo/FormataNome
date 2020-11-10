using System;
using System.Globalization;
using System.Threading;

namespace FormataNome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o nome a ser formatado: ");
            string nome = Console.ReadLine();

            string[] nomes = new string[100];
            string recebeNome = string.Empty;
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            for (int i = 0; i < nome.Length; i++)
            {

                nomes[i] = Convert.ToString(nome[i]);
                recebeNome += nomes[i];
            }

            Console.WriteLine(textInfo.ToTitleCase(textInfo.ToLower(recebeNome)));


            Console.ReadLine();
        }
    }
}
