using LeituraAcompanhada.Entities.Enums;
using System;

namespace LeituraAcompanhada.View.Utils
{
    public static class EntradaUtils
    {
        // Método genérico para validação de entrada
        private static T LerEntrada<T>(string mensagem, Func<string, (bool valido, T valor)> parser)
        {
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(entrada))
                {
                    ConsoleUtils.MostrarErro("A entrada não pode ser nula ou vazia!");
                    continue;
                }

                var (valido, valor) = parser(entrada);

                if (valido)
                {
                    return valor;
                }
                else
                {
                    ConsoleUtils.MostrarErro("Formato de entrada inválido!");
                }
            }
        }

        // Métodos específicos para cada tipo de dado
        public static string LerString(string mensagem)
        {
            return LerEntrada(mensagem, entrada =>
            {
                return (!string.IsNullOrWhiteSpace(entrada), entrada);
            });
        }

        public static DateTime LerData(string mensagem)
        {
            return LerEntrada(mensagem, entrada =>
            {
                var valido = DateTime.TryParse(entrada, out var valor);
                return (valido, valor);
            });
        }

        public static int LerInteiro(string mensagem)
        {
            return LerEntrada(mensagem, entrada =>
            {
                var valido = int.TryParse(entrada, out var valor);
                return (valido, valor);
            });
        }

        public static double LerDouble(string mensagem)
        {
            return LerEntrada(mensagem, entrada =>
            {
                var valido = double.TryParse(entrada, out var valor);
                return (valido, valor);
            });
        }

        public static T LerEnum<T>(string mensagem) where T : struct, Enum
        {
            return LerEntrada(mensagem, entrada =>
            {
                bool valido = Enum.TryParse(entrada, out T valor) && Enum.IsDefined(typeof(T), valor);
                return (valido, valor);
            });
        }
    }
}


