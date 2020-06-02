namespace Aula08Asbtracao
{
    public class Cartao : Pagamento
    {
        protected string token = "234f23f32ff34f34ff";
        public string bandeira { get; set; }
        public int numero { get; set; }
        public string titular { get; set; }
        protected string cvv { get; set; }
        public bool ValidarToken(){
            if(token != null){
            return true;
            }
            return false;
        }


    }
}