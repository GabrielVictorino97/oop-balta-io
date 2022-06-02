using OOP.NotificationContext;
using System;

namespace OOP.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

    }
}
