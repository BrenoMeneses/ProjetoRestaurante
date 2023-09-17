using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurante
{
    class Comanda
    {
        public int id;
        public double valorConsumo;
        public double valorEstacionamento;
        public double valorConvert;
        public double valorDescontoPromocional;
        public double valorTotal;

        public void lancarGastos(double consumo, double estacionamento, double couvert)
        {
            this.valorConsumo = consumo;
            this.valorEstacionamento = estacionamento;
            this.valorConvert = couvert;
            this.valorDescontoPromocional = 0;
            this.valorTotal = 0;
        }

        public void verificarPromocao()
        {
            if (this.valorConsumo > 100)
            {
                this.valorDescontoPromocional = this.valorConsumo * 0.1;
            }
            else
            {
                this.valorDescontoPromocional = 0;
            }
        }

        public void listarComanda()
        {
            Console.WriteLine("\nid: " + this.id
                + "\nvalor consumido: " + this.valorConsumo
                + "\nvalor do estacionamento: " + this.valorConvert
                + "\nvalor desconto: " + this.valorDescontoPromocional
                + "\nvalor total: " + this.valorTotal);
        }

    }
}
