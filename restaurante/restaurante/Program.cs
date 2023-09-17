using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurante
{
    class Program
    {
        static void Main(string[] args)
        {

            Comanda comanda = new Comanda();
            Caixa caixa = new Caixa();

            int a = 1;
            while (a != 0)
            {
                Console.Clear();
                Console.WriteLine("\n1-lançar gastos"
                    + "\n2-verificar promoção"
                    + "\n3-fechar mesa"
                    + "\n4-listar comanda"
                    + "\n0-sair");
                
                a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("quanto gastou no restaurante? ");
                        comanda.valorConsumo = double.Parse(Console.ReadLine());
                        Console.Write("quanto gastou no estacionamento? ");
                        comanda.valorEstacionamento = double.Parse(Console.ReadLine());
                        Console.Write("quanto gastou no couvert? ");
                        comanda.valorConvert = double.Parse(Console.ReadLine());
                        break;
                    case 2:
                        comanda.verificarPromocao();
                        Console.WriteLine("valor de promoção: " + comanda.valorDescontoPromocional);
                        break;
                    case 3:
                        caixa.totalizarGastos(comanda);
                        break;
                    case 4:
                        comanda.listarComanda();
                        break;
                }
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
