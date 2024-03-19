using fundamentosPOO.SharedContext;

namespace fundamentosPOO.ContentContext
{
    public class Module : Base
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }

        public int Order { get; set; }
        public string Title { get; set; } = null!;
        public IList<Lecture> Lectures { get; set; }
    }
}
