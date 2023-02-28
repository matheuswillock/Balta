using Balta.ContentContext;

namespace Balta
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet"));

            foreach (var article in articles)
            {
                Console.WriteLine($"Id do artigo: {article.Id}");
                Console.WriteLine($"Titulo: {article.Title}");
                Console.WriteLine($"URL: {article.Url}");
                Console.WriteLine("--------------------------");
            }

        }
    }
}