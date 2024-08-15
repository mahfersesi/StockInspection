namespace StockInspection.Modelos;
public class MetaDiaria : Registro
{
    int QuantidadeCorte;
    int QuantidadeCostura;
    int QuantidadeSilk;
    int QuantidadeAcabamento;
    public void SetQuantidadeCorte(int QuantidadeCorte)
{
    this.QuantidadeCorte = QuantidadeCorte;
}
public int GetQuantidadeCorte()
{
    return QuantidadeCorte;
}
public void SetQuantidadeCostura(int QuantidadeCostura)
{
    this.QuantidadeCostura = QuantidadeCostura;
}
public int GetQuantidadeCostura()
{
    return QuantidadeCostura;
}
public void SetQuantidadeSilk(int QuantidadeSilk)
{
    this.QuantidadeSilk = QuantidadeSilk;
}
public int GetQuantidadeSilk()
{
    return QuantidadeSilk;
}
public void SetQuantidadeAcabamento(int QuantidadeAcabamento)
{
    this.QuantidadeAcabamento = QuantidadeAcabamento;
}
public int GetQuantidadeAcabamento()
{
    return QuantidadeAcabamento;
}
}