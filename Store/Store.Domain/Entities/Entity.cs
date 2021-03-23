using System;

namespace Store.Domain.Entities
{
    public class Entity
    {
        public Entity()
        {
            //Gera o Id
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}
