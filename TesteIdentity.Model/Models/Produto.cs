using System;

namespace TesteIdentity.Model
{
    public class Produto
    {
        public long Id { get; set; }
        public string Marca { get; set; }
        public DateTime Validade { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
