using System;

namespace UserAPI.Domain.Interfaces.Entities
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
