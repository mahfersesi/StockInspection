namespace StockInspection.Modelos;
public class Silk : Registro
{
    string NomeSilk;
    int QuantidadeCamiseta;
    string NomeLote;

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
    public string GetQuantidadeCamiseta()
{
    return QuantidadeCamiseta;
}
 public void SetNomeLote(string NomeLote)
{
    this.NomeLote = NomeLote;
}
public string GetNomeLote()
{
    return NomeLote;
}

}