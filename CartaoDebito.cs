namespace Aula08Asbtracao
{
    public class CartaoDebito : Cartao
    {
        public float saldo;
        public string SaldoTransferido(){
            return "Tranferencia efetuada.";
        }
    }
}