using System;

namespace Aula08Asbtracao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito();
            visa.limite = 3000f;

            System.Console.WriteLine("Quanto de acrescentar no limite?");
            float acrescimo = float.Parse( Console.ReadLine() );

            visa.AumentarLimite(acrescimo);
            Console.WriteLine("Novo limite: R$" + visa.limite);

            System.Console.WriteLine("Digite a data do pagamento:");
            visa.data = DateTime.Parse(Console.ReadLine() );
            System.Console.WriteLine("Data: "+ visa.data);
        }
    }
}
