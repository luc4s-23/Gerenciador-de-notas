using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciador_de_notas.models
{
    public class NotaVenda
    {
        public int NumeroNota { get; set; }
        public DateTime DataAtual { get; set; }
        public List<ItemVenda> ListaItens { get; set; }

        public NotaVenda(int numeroNota, DateTime dataAtual, List<ItemVenda> listaItens)
        {
            NumeroNota = numeroNota;
            DataAtual = dataAtual;
            ListaItens = listaItens;
        }
    }
}