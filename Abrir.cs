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
            string texto = File.ReadAllText(path);

            // using(var save = new StreamReader(path))
            // {

            //     texto = save.ReadToEnd();
            Console.WriteLine(texto);              

            // }
            
            Editor.Comecar(texto);

        }        
    }
}