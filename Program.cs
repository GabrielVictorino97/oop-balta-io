using OOP.ContentContext;
using OOP.SubscriptionContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre c#", "csharp"));
            articles.Add(new Article("Artigo sobre database", "database"));
            articles.Add(new Article("Artigo sobre .Net", "dotnet"));

            //foreach (var item in articles)
            //{
            //    Console.WriteLine(item.Id);
            //    Console.WriteLine(item.Title);
            //    Console.WriteLine(item.Url);
            //}

            var courses = new List<Course>();

            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos Asp.Net", "fundamentos-dotnet");

            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotNet = new Career("Especialista .Net", "especialista-dotnet");
            var careerItem2 = new CareerItem(2, "Aprenda CSharp", "", null);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);
            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem);
            careerDotNet.Items.Add(careerItem3);
            careers.Add(careerDotNet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }

                var paypalSubscription = new PayPalSubscription();
                var student = new Student();

                student.CreateSubscription(paypalSubscription);
            }
        }
    }
}
