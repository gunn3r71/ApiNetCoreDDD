using ApiNetCoreDDD.Domain.Entities.Base;
using System;

namespace ApiNetCoreDDD.Domain.Entities
{
    public class User : Entity
    {
        public User(DateTime? createdAt, DateTime? updatedAt, string nome, string email)
            : base(createdAt, updatedAt)
        {
            Nome = nome;
            Email = email;
        }
        
        public string Nome { get; private set; }
        public string Email { get; private set; }
    }
}
