namespace Aula08Asbtracao
{
    public class Boleto : Pagamento
    {
        public string data_vencimento;
        public string banco_emissor;
        public string codigo_de_barras;
        public string RegistrarNoSistema(){
            return "Registrado";
        }
    }
}