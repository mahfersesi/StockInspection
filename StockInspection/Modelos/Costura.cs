namespace StockInspection.Modelos;
public class Costura : Registro
{
    string NomeCostureira;
    int QuantidadeFrente;
    int QuantidadeCostas;
    int QuantidadeLinha;

    public void SetNomeCostureira(string NomeCostureira)
{
    this.NomeCostureira = NomeCostureira;
}
public string GetNomeCostureira()
{
    return NomeCostureira;
}
public void SetQuantidadeFrente(int QuantidadeFrente)
{
    this.QuantidadeFrente = QuantidadeFrente;
}
public int GetQuantidadeFrente()
{
    return QuantidadeFrente;
}
public void SetQuantidadeCostas(int QuantidadeCostas)
{
    this.QuantidadeCostas = QuantidadeCostas;
}
public int GetQuantidadeCostas()
{
    return QuantidadeCostas;
}
public void SetQuantidadeLinha(int QuantidadeLinha)
{
    this.QuantidadeLinha = QuantidadeLinha;
}
public int GetQuantidadeLinha()
{
    return QuantidadeLinha;
}
}