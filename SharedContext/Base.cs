﻿using fundamentosPOO.NotificationContext;

namespace fundamentosPOO.SharedContext
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
