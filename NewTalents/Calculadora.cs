using System;
using System.Collections.Generic;

namespace NewTalents
{
    public class Calculadora
    {
        public Calculadora() => historico = new List<string>();

        private List<string> historico;

        private DateTime dataOperacao;

        public List<string> GetHistorico()
        {
            historico.RemoveRange(3, historico.Count -3);
            return historico;
        }



        public int Somar(int num1, int num2)
        {
            dataOperacao = DateTime.Now;
            var result = num1 + num2;
            var resultHist = $"{num1} + {num2} = {result} | {dataOperacao}\n";
            historico.Add(resultHist);
            return result;
        }

        public int Subtrair(int num1, int num2)
        {
            dataOperacao = DateTime.Now;
            var result = num1 - num2;
            var resultHist = $"{num1} - {num2} = {result} | {dataOperacao}\n";
            historico.Add(resultHist);
            return result;
        }

        public int Mutiplicar(int num1, int num2)
        {
            dataOperacao = DateTime.Now;
            var result = num1 * num2;
            var resultHist = $"{num1} x {num2} = {result} | {dataOperacao}\n";
            historico.Add(resultHist);
            return result;
        }

        public int Dividir(int num1, int num2)
        {
            dataOperacao = DateTime.Now;
            var result = num1 / num2;
            var resultHist = $"{num1} / {num2} = {result} | {dataOperacao}\n";
            historico.Add(resultHist);
            return result;
        }
    }
}
