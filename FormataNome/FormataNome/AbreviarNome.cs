using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

namespace FormataNome
{
    public class AbreviarNome
    {
        public string abreviandoNome(string nome)
        {

            string[] n = nome.Split(' ');

            string sigla = "";

            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            

            for (int i = 0; i < n.Length; i++)
            {
                //Dispenso a palavras menores que 3 caracteres
                if (n[i].Length > 3)
                {
                    //Pego somente a primeira da palavra
                    sigla = sigla + n[i].Substring(0, 1);
                }
            }

            return sigla;
        }
    }
}
