namespace NerdStore.Vendas.Application.Queries.ViewModels
{
    public class CarrinhoPagamentoViewModel
    {
        private string _NomeCartao;
        public string NomeCartao
        {
            get { return _NomeCartao; }
            set { _NomeCartao = value; }
        }

        private string _NumeroCartao;
        public string NumeroCartao
        {
            get { return _NumeroCartao; }
            set { _NumeroCartao = value; }
        }

        private string _ExpiracaoCartao;
        public string ExpiracaoCartao
        {
            get { return _ExpiracaoCartao; }
            set { _ExpiracaoCartao = value; }
        }

        private string _CvvCartao;
        public string CvvCartao
        {
            get { return _CvvCartao; }
            set { _CvvCartao = value; }
        }
    }
}
