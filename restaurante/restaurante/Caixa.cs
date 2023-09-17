using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurante
{
    class Caixa
    {

        public double totalizarGastos(Comanda comanda)
        {
            comanda.valorTotal = comanda.valorConsumo + comanda.valorEstacionamento + comanda.valorConvert - comanda.valorDescontoPromocional;
            return comanda.valorTotal;
        }

    }
}
