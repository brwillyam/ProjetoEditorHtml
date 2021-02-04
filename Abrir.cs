using System;
using System.IO;

namespace EditorTextoHtml
{
    public class Abrir 
    {
        public static void abrir()
        {
            Console.Clear();
            Console.WriteLine("qual o caminho do arquivo?");
            string path = Console.ReadLine();

            using(var save = new StreamReader(path))
            {

                string texto = save.ReadToEnd();
                Console.WriteLine(texto);

            }
            Editor.Comecar();

        }        
    }
}