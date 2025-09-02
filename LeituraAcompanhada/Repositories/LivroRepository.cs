using LeituraAcompanhada.Entities;
using LeituraAcompanhada.Entities.Enums;
using System.Text.Json;

namespace LeituraAcompanhada.Repositories
{
    class LivroRepository
    {
        private static string _caminhoArquivo = "livros.json";

        public static void Salvar(List<Livro> livro)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(livro, options);
                File.WriteAllText(_caminhoArquivo, json);
            }
            catch (JsonException e)
            {
                throw new Exception("Erro na serialização do JSON: " + e.Message);
            }
        }
        public static List<Livro> Carregar()
        {
            if (File.Exists(_caminhoArquivo))
            {
                string json = File.ReadAllText(_caminhoArquivo);
                var livros = JsonSerializer.Deserialize<List<Livro>>(json);

                return livros;
            }
            return new List<Livro>();
        }
    }
}
