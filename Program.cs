using fundamentosPOO.ContentContext;

namespace fundamentosPOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Aprenda sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Aprenda sobre C#", "csharp"));
            articles.Add(new Article("Aprenda sobre EF", "entity-framework"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
        }
    }
}