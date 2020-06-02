using System;

namespace Aula08Asbtracao
{
    public class Pagamento
    {
        public DateTime data {get; set;}
        public float valor {get; set;}
        public string Pagar(float ValorPago){
            return "ValorPago: R$ "+ ValorPago;
        }
        public string cancelar(){
            return "Pagamento cancelado.";
        }
    }
}