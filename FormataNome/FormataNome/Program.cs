using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace FormataNome
{
    class Program
    {
        static void Main(string[] args)
        {
            string ativo = "s";

            while (ativo == "s")
            {

                Console.Write("Insira o nome a ser formatado: ");
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
                Console.WriteLine(nomes[0]);
                Console.WriteLine(textInfo.ToTitleCase("Nome Formatado: "+textInfo.ToLower(recebeNome)));


                AbreviarNome abreviarNome = new AbreviarNome();

                Console.WriteLine("Nome Abreviado: " + abreviarNome.abreviandoNome(textInfo.ToUpper(recebeNome)));


                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("          Deseja continuar? (s/n)");
                ativo = Console.ReadLine();
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine();

            }

            Console.WriteLine("bye bye...");




            Console.ReadLine();
        }
    }
}
