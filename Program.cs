using fundamentosPOO.ContentContext;
using fundamentosPOO.SubscriptionContext;

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

            //foreach (var article in articles)
            //{
            //    Console.WriteLine(article.Id);
            //    Console.WriteLine(article.Title);
            //    Console.WriteLine(article.Url);
            //}

            var courses = new List<Course>();
            var careers = new List<Career>();

            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseEf = new Course("Fundamentos Entity Framework", "fundamentos-ef");
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseEf);


            var careerItem1 = new CareerItem(1, "Comece por aqui", "Aprenda C#", courseCsharp);
            var careerItem2 = new CareerItem(2, "Avance no desenvolvimento", "Aprenda OOP", null);
            var careerItem3 = new CareerItem(3, "Acesso a dados", "Aprenda EF", courseEf);

            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem1);
            careerDotnet.Items.Add(careerItem3);

            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine($"\n{career.Title}");
                foreach (var careerItem in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{careerItem.Order} - {careerItem.Title}");
                    foreach (var notification in careerItem.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }

                Console.WriteLine($"\n");
            }

            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(payPalSubscription);
        }
    }
}