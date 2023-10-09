using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;
using static Utilitarios;

namespace Projeto1
{
    class Program
    {
        static void SelecionarOpcoes()
        {
            int opcao;

            do
            {
                EscreverXY(3, 4, "1 - MMC entre dois valores digitados");
                EscreverXY(3, 6, "2 - Números centrais");
                EscreverXY(3, 8, "3 - Cálculos de Pi");
                EscreverXY(3, 10, "4 - Lista de números de Fibonacci");
                EscreverXY(3, 12, "5 - Raiz Quadrada de um real digitado");
                EscreverXY(3, 14, "6 - Processamento de dados armazenados em um arquivo texto em disco");
                EscreverXY(3, 16, "0 - Terminar o programa");
                EscreverXY(3, 20, "Selecione a opção desejada: ");
                opcao = int.Parse(ReadLine());

                switch (opcao)
                {
                    case 3:
                        CalcularPi();
                        break;
                }
            }
            while (opcao != 0);
        }
        static void CalcularPi()
        {
            Clear();

            EscreverXY(3, 4, "Digite a quantidade de repetições que deveram ser executadas no cálculo: ");
            int numDigitado = int.Parse(ReadLine());

            var oPi = new Matematica(numDigitado);

            EscreverXY(3, 8, $"O valor aproximado de PI é: {oPi.Pi()}");
            EsperarEnter();
        }
        static void Main(string[] args)
        {
            SelecionarOpcoes();
        }
    }
}
