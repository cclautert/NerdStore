using NerdStore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain
{
    public class Produto : Entity, IAggregateRoot
    {
        private string _Nome;
        public string Nome {
            get { return _Nome; }
            private set { _Nome = value; }
        }

        private string _Descricao;

        public string Descricao {
            get { return _Descricao; }
            private set { _Descricao = value; }
        }

        private bool _Ativo;
        public bool Ativo {
            get { return _Ativo; }
            private set { _Ativo = value; }
        }

        private decimal _Valor;
        public decimal Valor {
            get { return _Valor; }
            private set { _Valor = value; }
        }

        private DateTime _DataCadastro;
        public DateTime DataCadastro {
            get { return _DataCadastro; }
            private set { _DataCadastro = value; }
        }

        private string _Imagem;
        public string Imagem {
            get { return _Imagem; }
            private set { _Imagem = value; }
        }

        private int _QuantidadeEstoque;
        public int QuantidadeEstoque {
            get { return _QuantidadeEstoque; }
            private set { _QuantidadeEstoque = value; }
        }

        private Categoria _Categoria;
        public Categoria Categoria {
            get { return _Categoria; }
            private set { _Categoria = value; }
        }

    }

    public class Categoria : Entity, IAggregateRoot
    {
    }
}
