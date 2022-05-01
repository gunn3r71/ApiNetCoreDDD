using System;

namespace ApiNetCoreDDD.Domain.Entities.Base
{
    public abstract class Entity
    {
        protected Entity(DateTime? createdAt, 
            DateTime? updatedAt)
        {
            Id = Guid.NewGuid();
            CreatedAt = createdAt ?? DateTime.UtcNow;
            UpdatedAt = updatedAt;
        }

        public Guid Id { get; private set; }
        public DateTime? CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }
    }
}
