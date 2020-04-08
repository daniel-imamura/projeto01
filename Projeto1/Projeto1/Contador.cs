class Contador
{
    protected int
        contador,
        passo,
        valorInicial,
        valorFinal;
    public Contador()
    {
        Iniciar(1, 0, 1);
    }
    public void Iniciar(int inicio, int fim, int incremento)
    {
        valorInicial = inicio;
        valorFinal = fim;
        passo = incremento;
        contador = valorInicial;
    }
    public void Contar()
    {
        if (contador <= valorFinal)
            contador += passo;
    }

    public bool Prosseguir()
    {
        return contador <= valorFinal;
    }

    public int Valor
    {
        get { return contador; }
    }
}


