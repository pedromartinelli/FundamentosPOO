using fundamentosPOO.ContentContext;
using fundamentosPOO.ContentContext.Enums;

namespace fundamentosPOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            var course = new Course();
            course.Level = EContentLevel.Beginner;
        }
    }
}