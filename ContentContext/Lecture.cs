using fundamentosPOO.ContentContext.Enums;
using fundamentosPOO.SharedContext;

namespace fundamentosPOO.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; } = null!;
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}
