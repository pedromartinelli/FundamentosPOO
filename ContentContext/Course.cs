using fundamentosPOO.ContentContext.Enums;

namespace fundamentosPOO.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            Modules = new List<Module>();
        }

        public string Tag { get; set; } = null!;
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}
