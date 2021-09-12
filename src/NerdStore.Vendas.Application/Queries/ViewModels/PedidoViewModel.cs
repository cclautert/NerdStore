using System;

namespace NerdStore.Vendas.Application.Queries.ViewModels
{
    public class PedidoViewModel
    {
        private Guid _Id;
        public Guid Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private int _Codigo;
        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private decimal _ValorTotal;
        public decimal ValorTotal
        {
            get { return _ValorTotal; }
            set { _ValorTotal = value; }
        }

        private DateTime _DataCadastro;
        public DateTime DataCadastro
        {
            get { return _DataCadastro; }
            set { _DataCadastro = value; }
        }

        private int _PedidoStatus;
        public int PedidoStatus
        {
            get { return _PedidoStatus; }
            set { _PedidoStatus = value; }
        }
    }
}
