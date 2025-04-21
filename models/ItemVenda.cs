using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciador_de_notas.models
{
    public class ItemVenda
    {
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

        public decimal Total => Quantidade * PrecoUnitario;

        public ItemVenda(string nomeProduto, int quantidade, decimal precoUnitario)
        {
            NomeProduto = nomeProduto;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }
        public override string ToString()
        {
            return $"{NomeProduto} - Qtd: {Quantidade}, Unitário: {PrecoUnitario:C}, Total: {Total:C}";
        }
    }

}