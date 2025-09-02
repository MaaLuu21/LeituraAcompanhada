using LeituraAcompanhada.View;
using System;

namespace LeituraAcompanhada
{
    class LeituraAcompanhada
    {
        static void Main(string[] args)
        {
            try
            {
                MenuView.Menu();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
        }
    }
}