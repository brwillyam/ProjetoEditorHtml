using System;

namespace EditorTextoHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            Opcoes();
            var opcao = short.Parse(Console.ReadLine());
            ManipulaOpcao(opcao);
            

        }

        public static void DrawScreen()
        {
          
            Topoefim();
            Altura();
            Topoefim();

                
        }
        
        public static void Topoefim()
        {
              Console.Write("+");
            for(int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }
    
        public static void Altura()
        {
            for(int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for(int i = 0; i <=30; i++)
                
                   Console.Write(" ");

                   Console.Write("|");
                   Console.Write("\n");
                }
        }
        
        public static void Opcoes()
        {
            Console.SetCursorPosition(3,2);
            Console.WriteLine("Editor deTexto Html");
            Console.SetCursorPosition(3,3);
            Console.WriteLine("=====================");
            Console.SetCursorPosition(3,4);
            Console.WriteLine("Selecione a opcao desejada: ");
            Console.SetCursorPosition(3,6);
            Console.WriteLine("1 - NOVO ARQUIVO");
            Console.SetCursorPosition(3,7);
            Console.WriteLine("2 - ABRIR ");
            Console.SetCursorPosition(3,9);
            Console.WriteLine("0 - SAIR");
            Console.SetCursorPosition(3,10);
            Console.Write("Opção:");
            

        }

        public static void ManipulaOpcao(short opcao)
        {
            switch (opcao)
            {
                case 1: Editor.Show();break;
                case 2: Console.WriteLine("visualizador");break;
                case 0:{
                    Console.Clear();
                    Environment.Exit(0); 
                    break;

                }
                default: Show(); break;
            }
        }
    
    }
}