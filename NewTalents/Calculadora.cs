using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> HistoricoContas = [];

        public int Somar(int numero1, int numero2)
        {
            int result = numero1 + numero2;
            InserirNoHistorico($"{numero1} + {numero2} = {result}");
            return result;
        }

        public int Subtrair(int numero1, int numero2)
        {
            int result = numero1 - numero2;
            InserirNoHistorico($"{numero1} - {numero2} = {result}");
            return result;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            int result = numero1 * numero2;
            InserirNoHistorico($"{numero1} * {numero2} = {result}");
            return result;
        }

        public int Dividir(int numero1, int numero2)
        {
            int result = numero1 / numero2;
            InserirNoHistorico($"{numero1} / {numero2} = {result}");
            return result;
        }

        public void InserirNoHistorico(string conta)
        {
            if(HistoricoContas.Count >= 3)
                HistoricoContas.RemoveAt(0);
            HistoricoContas.Add(conta);
        }

        public List<string> Historico()
        {
            return HistoricoContas;
        }
    }
}