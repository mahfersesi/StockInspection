namespace StockInspection.Modelos;
public class Corte : Registro
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