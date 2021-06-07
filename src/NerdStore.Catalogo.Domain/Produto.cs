using NerdStore.Core.DomainObjects;
using System;

namespace NerdStore.Catalogo.Domain
{
    public class Produto : Entity, IAggregateRoot
    {
        private Guid _CategoriaId;
        public Guid CategoriaId {
            get { return _CategoriaId; }
            private set { _CategoriaId = value; }
        }

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

        private Dimensoes _Dimensoes;
        public Dimensoes Dimensoes {
            get { return _Dimensoes; }
            private set { _Dimensoes = value; }
        }

        private Categoria _Categoria;
        public Categoria Categoria {
            get { return _Categoria; }
            private set { _Categoria = value; }
        }

        public Produto(string Nome, string Descricao, bool Ativo, decimal Valor, Guid CategoriaId, DateTime DataCadastro, string Imagem, Dimensoes dimensoes)
        {
            _CategoriaId = CategoriaId;
            _Nome = Nome;
            _Descricao = Descricao;
            _Ativo = Ativo;
            _Valor = Valor;
            _DataCadastro = DataCadastro;
            _Imagem = Imagem;
            _Dimensoes = dimensoes;

            Validar();
        }

        //Ad Hoc Setter
        public void Ativar() => _Ativo = true;
        public void Desativar() => _Ativo = false;

        public void AlterarCategoria(Categoria categoria)
        {
            _Categoria = categoria;
            _CategoriaId = categoria.Id;
        }

        public void AlterarDescricao(string descricao)
        {
            Validacoes.ValidarSeVazio(descricao, "O campo Descricao do produto não pode estar vazio");
            _Descricao = descricao;
        }

        public void DebitarEstoque(int quantidade)
        {
            if (quantidade < 0) quantidade *= -1;
            if (!PossuiEstoque(quantidade)) throw new DomainException("Estoque insuficiente");
            _QuantidadeEstoque -= quantidade;
        }
        public void ReporEstoque(int quantidade)
        {
            _QuantidadeEstoque += quantidade;
        }

        public bool PossuiEstoque(int quantidade)
        {
            return _QuantidadeEstoque >= quantidade;
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O campo Nome do produto não pode estar vazio");
            Validacoes.ValidarSeVazio(Descricao, "O campo Descricao do produto não pode estar vazio");
            Validacoes.ValidarSeIgual(CategoriaId, Guid.Empty, "O campo CategoriaId do produto não pode estar vazio");
            Validacoes.ValidarSeMenorQue(Valor, 1, "O campo Valor do produto não pode se menor igual a 0");
            Validacoes.ValidarSeVazio(Imagem, "O campo Imagem do produto não pode estar vazio");
        }
    }
}
