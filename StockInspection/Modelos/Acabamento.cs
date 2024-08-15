namespace StockInspection.Modelos;
public class Acabamento : Registro
{
    string NomeAcabamento;
    int QuantidadeCamiseta;
    int QuantidadeEmbalagem;
    int QuantidadeTamanho;
    int QuantidadeTiras;

    public void SetNomeAcabamento(string NomeAcabamento)
{
    this.NomeAcabamento = NomeAcabamento;
}
public string GetNomeAcabamento()
{
    return NomeAcabamento;
}
 public void SetQuantidadeCamiseta(int QuantidadeCamiseta)
{
    this.QuantidadeCamiseta = QuantidadeCamiseta;
}
public int GetQuantidadeCamiseta()
{
    return QuantidadeCamiseta;
}
 public void SetQuantidadeEmbalagem(int QuantidadeEmbalagem)
{
    this.QuantidadeEmbalagem = QuantidadeEmbalagem;
}
public int GetQuantidadeEmbalagem()
{
    return QuantidadeEmbalagem;
}
 public void SetQuantidadeTamanho(int QuantidadeTamanho)
{
    this.QuantidadeTamanho = QuantidadeTamanho;
}
public int GetQuantidadeTamanho()
{
    return QuantidadeTamanho;
}
 public void SetQuantidadeTiras(int QuantidadeTiras)
{
    this.QuantidadeTiras = QuantidadeTiras;
}
public int GetQuantidadeTiras()
{
    return QuantidadeTiras;
}
}