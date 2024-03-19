using fundamentosPOO.SharedContext;

namespace fundamentosPOO.ContentContext
{
    // abstract - não pode ser instanciada
    public abstract class Content : Base
    {
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }

        public string Title { get; set; }
        public string Url { get; set; }
    }
}
