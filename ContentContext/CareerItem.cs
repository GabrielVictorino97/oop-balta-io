using OOP.SharedContext;

namespace OOP.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(int ordem, string title, string description, Course course)
        {
            if (course == null)
                AddNotification(new NotificationContext.Notification("Course", "Curso inválido"));

            Order = ordem;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}
