namespace fundamentosPOO.ContentContext
{
    // abstract - não pode ser instanciada
    public abstract class Content
    {
        public Content()
        {
            Id = new Guid(); // SPOF
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
