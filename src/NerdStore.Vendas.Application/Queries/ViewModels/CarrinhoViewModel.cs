using System;
using System.Collections.Generic;

namespace NerdStore.Vendas.Application.Queries.ViewModels
{
    public class CarrinhoViewModel
    {
        private Guid _PedidoId;
        public Guid PedidoId
        {
            get { return _PedidoId; }
            set { _PedidoId = value; }
        }

        private Guid _ClienteId;
        public Guid ClienteId
        {
            get { return _ClienteId; }
            set { _ClienteId = value; }
        }

        private decimal _SubTotal;
        public decimal SubTotal
        {
            get { return _SubTotal; }
            set { _SubTotal = value; }
        }

        private decimal _ValorTotal;
        public decimal ValorTotal
        {
            get { return _ValorTotal; }
            set { _ValorTotal = value; }
        }

        private decimal _ValorDesconto;
        public decimal ValorDesconto
        {
            get { return _ValorDesconto; }
            set { _ValorDesconto = value; }
        }

        private string _VoucherCodigo;
        public string VoucherCodigo
        {
            get { return _VoucherCodigo; }
            set { _VoucherCodigo = value; }
        }

        public List<CarrinhoItemViewModel> Items { get; set; } = new List<CarrinhoItemViewModel>();
        public CarrinhoPagamentoViewModel Pagamento { get; set; }
    }
}
