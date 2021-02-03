using System;
using System.IO;

namespace EditorTextoHtml
{
    public class Abrir
    {
        public static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("qual o caminho do arquivo?");
            string caminho = Console.ReadLine();

            using(var save = new StreamReader(caminho))
            {

                string texto = save.ReadToEnd();
                Console.WriteLine(texto);

            }
            Console.ReadLine();

        }        
    }
}