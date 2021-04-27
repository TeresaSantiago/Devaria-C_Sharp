using System;

namespace ListaDeConvidados
{
    class Program
    {
        private static string[] ListaDeConvidados =
        {
            "Daniel";   // Posição 0
            "Evandro";  // Posição 1
            "Matheus";  // Posição 2
            "Ale";      // Posição 3
            "Teresa";   // Posição 4
            "Gabriel";  // Posição 5
            "Cledson";  // Posição 6
            "Giuseppe"; // Posição 7
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do convidado: ");
            var nome = Console.ReadLine();
            
            if(nome == null || string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Nome não informado para seguir com o programa");
                return;
            }
            
               
    }
}
