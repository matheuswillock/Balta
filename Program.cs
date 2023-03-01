using Balta.ContentContext;
using Balta.SubcscriptionContext;

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

            var courses = new List<Course>();

            var courseOOP = new Course("Fundamentos OOP", "Fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "Fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET", "Fundamentos-aspnet");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");

            var careerItem2 = new CareerItem(3, "Aprenda OOP", "", null);
            var careerItem1 = new CareerItem(2, "Aprenda .NET", "", null);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);

            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItem1);

            careers.Add(careerDotnet);

            foreach(var carrer in careers) 
            {
                Console.WriteLine(carrer.Title);
                foreach (var item in carrer.Items.OrderBy(x => x.Order)) { 
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications) 
                    { 
                        Console.WriteLine($"{notification.property} - {notification.Message}");
                    }
                }
            }

            var payPalSubscription = new PayPalSubscription();
            var student = new Student();
            student.CreateSubscription(payPalSubscription);

            // Console do student com a subscription
        }
    }
}