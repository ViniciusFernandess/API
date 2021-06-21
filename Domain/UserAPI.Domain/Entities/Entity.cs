using System;
using System.ComponentModel.DataAnnotations;

namespace UserAPI.Domain.Entities
{
    public abstract class Entity// : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        private DateTime? _dataCadastro;

        public DateTime? DataCadastro
        {
            get { return _dataCadastro; }
            set { _dataCadastro = (value == null ? DateTime.Now : value); }
        }


    }
}
