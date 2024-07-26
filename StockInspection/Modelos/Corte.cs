namespace Modelos;
public class Corte : Cliente
{
    string NomeCortador;
    int Quantidade;

    public void SetNomeCortador(string NomeCortador)
{
    this.NomeCortador= NomeCortador;
}
public string GetNomeCortador()
{
    return NomeCortador;
}
public void SetQuantidade(int Quantidade)
{
    this.Quantidade= Quantidade;
}
public int GetQuantidade()
{
    return Quantidade;
}
}