namespace StockInspection.Modelos;
public class MateriaP : Cliente
{
    string NomeMP;
    string UnidadeDeMedida;
    string NomeCliente;


public void SetNomeCliente(string NomeCliente)
{
    this.NomeCliente= NomeCliente;
}
public string GetNomeCliente()
{
    return NomeCliente;
}

public void SetUnidadeDeMedida(string UnidadeDeMedida)
{
    this.UnidadeDeMedida= UnidadeDeMedida;
}
public string GetUnidadeDeMedida()
{
    return UnidadeDeMedida;
}

public void SetNomeMP(string NomeMP)
{
    this.NomeMP= NomeMP;
}
public string GetNomeMP()
{
    return NomeMP;
}
}