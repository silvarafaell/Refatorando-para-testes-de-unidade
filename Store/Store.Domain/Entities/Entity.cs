using System;
using Flunt.Notifications;

namespace Store.Domain.Entities
{
    public class Entity : Notifiable
    {
        public Entity()
        {
            //Guid gera o Id identificador unico
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}
