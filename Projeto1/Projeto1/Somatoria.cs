class Somatoria
{
    protected double
        soma;

    protected int
        quantidadeValores;

    bool houveErroMedia;
    public Somatoria()
    {
        soma = 0;
        quantidadeValores = 0;
        houveErroMedia = false;
    }

    public void Somar(double valorASomar)
    {
        soma += valorASomar;
        quantidadeValores++;
    }
    public double MediaAritmetica()
    {
        houveErroMedia = false;
        if (quantidadeValores > 0)
            return soma / quantidadeValores;

        houveErroMedia = true;
        return default(double);
    }
    
    public double Valor
    {
        get { return soma; }
    }
    public int Quantos
    {
        get { return quantidadeValores; }
    }
}


