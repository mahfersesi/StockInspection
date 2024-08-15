namespace StockInspection.Modelos;
public class Silk : Registro
{
    string NomeSilk;
    int QuantidadeCamiseta;
    int NomeLote;

    public void SetNomeSilk(string NomeSilk)
{
    this.NomeSilk = NomeSilk;
}
public string GetNomeSilk()
{
    return NomeSilk;
}
    public void SetQuantidadeCamiseta(int QuantidadeCamiseta)
{
    this.QuantidadeCamiseta= QuantidadeCamiseta;
}
    public int GetQuantidadeCamiseta()
{
    return QuantidadeCamiseta;
}
 public void SetNomeLote(int NomeLote)
{
    this.NomeLote = NomeLote;
}
public int GetNomeLote()
{
    return NomeLote;
}

}