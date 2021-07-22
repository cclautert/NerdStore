using System;

namespace NerdStore.Vendas.Application.Queries.ViewModels
{
    public class CarrinhoItemViewModel
    {
        private Guid _ProdutoId;
        public Guid ProdutoId
        {
            get { return _ProdutoId; }
            set { _ProdutoId = value; }
        }

        private string _ProdutoNome;
        public string ProdutoNome
        {
            get { return _ProdutoNome; }
            set { _ProdutoNome = value; }
        }

        private int _Quantidade;
        public int Quantidade
        {
            get { return _Quantidade; }
            set { _Quantidade = value; }
        }

        private decimal _ValorUnitario;
        public decimal ValorUnitario
        {
            get { return _ValorUnitario; }
            set { _ValorUnitario = value; }
        }

        private decimal _ValorTotal;
        public decimal ValorTotal
        {
            get { return _ValorTotal; }
            set { _ValorTotal = value; }
        }
    }
}
