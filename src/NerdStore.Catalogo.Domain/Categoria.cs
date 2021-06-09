using NerdStore.Core.DomainObjects;
using System.Collections.Generic;

namespace NerdStore.Catalogo.Domain
{
    public class Categoria: Entity, IAggregateRoot
    {
        private string _Nome;
        public string Nome {
            get { return _Nome; }
            private set { _Nome = value; }
        }

        private int _Codigo;
        public int Codigo {
            get { return _Codigo; }
            private set { _Codigo = value; }
        }
        public ICollection<Produto> Produtos { get; set; }

        protected Categoria() {}

        public Categoria(string nome, int codigo)
        {
            _Nome = nome;
            _Codigo = codigo;

            Validar();
        }

        public override string ToString()
        {
            return $"{_Nome} - {_Codigo}";
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(_Nome, "O campo Nome da categoria não pode estar vazio");
            Validacoes.ValidarSeIgual(_Codigo, 0, "O campo Codigo não pode ser 0");
        }
    }
}
