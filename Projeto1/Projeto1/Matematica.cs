using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;
class Matematica
{
    int numInt;
    public Matematica(int valorDesejado)
    {
        numInt = valorDesejado;
    }
    public int Fatorial()
    {
        var umFatorial = new Produtorio();
        var contaFatorial = new Contador();
        contaFatorial.Iniciar(1, numInt, 1);
        while (contaFatorial.Prosseguir())
        {
            umFatorial.Multiplicar(contaFatorial.Valor);
            contaFatorial.Contar();
        }
        return Convert.ToInt32(umFatorial.Valor);
    }
    public string Divisores()
    {
        int quociente,
            resto,
            metadeNum,
            divisor;

        string lista = "";
        metadeNum = numInt / 2;
        var contaDivisores = new Contador();
        contaDivisores.Iniciar(2, metadeNum, 1);

        while (contaDivisores.Prosseguir())
        {
            divisor = contaDivisores.Valor;
            quociente = numInt / divisor;
            resto = numInt - quociente * divisor;

            if (resto == 0)
                lista = lista + Convert.ToString(divisor) + ", ";

            contaDivisores.Contar();
        }
        return "1, " + lista + numInt;
    }
    public int mdc(int segundoNum)
    {
        int resto = 0;
        int oMdc = 0;
        int divisor = segundoNum;
        int dividendo = numInt;
        do
        {
            int quociente = dividendo / divisor;
            resto = dividendo - quociente * divisor;

            if (resto == 0)
                oMdc = divisor;

            dividendo = divisor;
            divisor = resto;
        }
        while (resto != 0);
        return oMdc;
    }
    public bool Palindromo()
    {
        int aux = 0;
        int numDigitado = numInt;
        while (numDigitado > 0)
        {
            int quociente = numDigitado / 10;
            int resto = numDigitado - quociente * 10;
            aux = aux * 10 + resto;
            numDigitado = quociente;
        }
        return aux == numInt;
    }
    public int SomarDivisores()
    {
        int quociente,
            resto,
            divisor;

        var somaDivisores = new Somatoria();
        var contaDivisores = new Contador();
        contaDivisores.Iniciar(1, numInt, 1);

        while (contaDivisores.Prosseguir())
        {
            divisor = contaDivisores.Valor;
            quociente = numInt / divisor;
            resto = numInt - quociente * divisor;

            if (resto == 0)
                somaDivisores.Somar(divisor);

            contaDivisores.Contar();
        }
        return Convert.ToInt32(somaDivisores.Valor);
    }
    public bool EhPerfeito()
    {
        int metadeNum = SomarDivisores() / 2;

        if (numInt == metadeNum)
            return true;

        else
            return false;
    }
    public bool EhPrimo()
    {
        string divisores = Divisores();

        if (numInt != 1 && divisores == $"1, {numInt}")
        {
            return true;
        }

        else
            return false;
    }

    public int mmc(int outroValor)
    {
        int num = numInt;

        var oMmc = new Produtorio();
        var umCont = new Contador();

        umCont.Iniciar(2, int.MaxValue, 1);

        while (numInt != 1 && outroValor != 1)
        {
            numInt = umCont.Valor;
            if (EhPrimo())
            {
                if (outroValor % umCont.Valor == 0)
                    outroValor /= umCont.Valor;
                if (num % umCont.Valor == 0)
                    num /= umCont.Valor;
                oMmc.Multiplicar(umCont.Valor);
            }
            umCont.Contar();
        }
        return Convert.ToInt32(oMmc.Valor);
    }
    public double Cosseno(double anguloEmGraus)
    {
        double cosX = 1;
        double radianos = (PI * anguloEmGraus / 180);

        var contaQuant = new Contador();
        var contaFatorial = new Contador();
        var positivoeNegativo = new Contador();

        positivoeNegativo.Iniciar(1, 0, 1);
        contaQuant.Iniciar(2, numInt * 2, 2);

        while (contaQuant.Prosseguir())
        {
            numInt = contaQuant.Valor;
            cosX += Pow(-1, positivoeNegativo.Valor) * Pow(radianos, contaQuant.Valor) / Fatorial();

            positivoeNegativo.Contar();
            contaQuant.Contar();
        }
        return cosX;

    }
    public double Pi()
    {

        var umaSoma = new Somatoria();
        var umContador = new Contador();
        var positivoeNegativo = new Contador();
        positivoeNegativo.Iniciar(2, 0, 1);

        umContador.Iniciar(1, numInt, 2);
        while (umContador.Prosseguir())
        {
            umaSoma.Somar(1 / (Pow(-1, positivoeNegativo.Valor) * Pow(umContador.Valor, 3)));

            umContador.Contar();
            positivoeNegativo.Contar();
        }
        return Pow(32 * umaSoma.Valor, 1.0 / 3);
    }

    public void Trocar(int primeiroValor, int segundoValor)
    {
        int primeiro = primeiroValor;
        primeiroValor = segundoValor;
        segundoValor = primeiro;

        WriteLine($"Primeiro parâmetro: {primeiroValor}        Segundo parâmetro: {segundoValor}");
    }
    public int CalcularRaiz()
    {
        double aproximacao = numInt;
        double raiz;
        do
        {
            raiz = ((aproximacao + numInt) / aproximacao) / 2.0;
            if (Abs(aproximacao / (raiz - 1)) > 0.0001)
                aproximacao = raiz;
        }
        while (Abs(aproximacao / (raiz - 1)) > 0.0001);

        return Convert.ToInt32(raiz);
    }
    public int ParaBinario()
    {
        int resto;
        int numero = numInt;
        double numBinario = 0;

        var umExpoente = new Contador();
        umExpoente.Iniciar(0, int.MaxValue, 1);
        while (numero != 0)
        {
            resto = numero % 2;

            numBinario += resto * Pow(10, umExpoente.Valor);

            numero /= 2;
            umExpoente.Contar();
        }
        return Convert.ToInt32(numBinario);

    }
}

