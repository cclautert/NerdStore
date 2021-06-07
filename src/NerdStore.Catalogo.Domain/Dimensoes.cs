using NerdStore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain
{
    public class Dimensoes
    {
        private decimal _altura;

        public decimal altura {
            get { return _altura; }
            private set { _altura = value; }
        }

        private decimal _Largura;
        public decimal Largura {
            get { return _Largura; }
            private set { _Largura = value; }
        }

        private decimal _Profundidade;
        public decimal Profundidade {
            get { return _Profundidade; }
            private set { _Profundidade = value; }
        }

        public Dimensoes(decimal altura, decimal largura, decimal profundidade)
        {
            Validacoes.ValidarSeMenorQue(altura, 1, "O campo Altura não pode ser menor ou igual a 0");
            Validacoes.ValidarSeMenorQue(largura, 1, "O campo Largura não pode ser menor ou igual a 0");
            Validacoes.ValidarSeMenorQue(profundidade, 1, "O campo Profundidade não pode ser menor ou igual a 0");

            _altura = altura;
            _Largura = largura;
            _Profundidade = profundidade;
        }

        public string DescricaoFormatada()
        {
            return $"LxAxP: {_Largura} x {_altura} x {_Profundidade}";
        }

        public override string ToString()
        {
            return DescricaoFormatada();
        }
    }
}
