using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, vista, cartao, cartao3;
            String pagamento;
            Console.WriteLine("========================LOJAS MUNIZ====================");
            Console.Write("Preço das compras: R$");
            valor = double.Parse(Console.ReadLine());
            Console.Write("Como deseja efetuar o pagamento: ");
            pagamento = Console.ReadLine();
            vista = valor * 10 / 100;
            cartao = valor * 5 / 100;
            cartao3 = valor * 20 / 100;
            if (pagamento == "Dinheiro") {
                Console.WriteLine("Desconto foi: " + vista);
                Console.Write("O valor á pagar será: " + (valor - vista));
            }
            else if (pagamento == "Cartão") {
                Console.WriteLine("Desconto foi: " + cartao);
                Console.Write("O valor a pagar será: " + (valor - cartao));
            }
            else if (pagamento == "2x no cartão"){
                Console.Write("O valor a pagar será: " + valor);
            }
            else{
                Console.WriteLine("Acrescimo de: " + cartao3);
                Console.Write("O valor a pagar será: " + (valor + cartao3));
            }

            Console.ReadKey();
        }
    }
}
