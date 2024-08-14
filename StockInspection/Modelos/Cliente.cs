namespace StockInspection.Modelos;
public class Cliente : Registro
{
    string cpf;
    int Numero;
    string endereço;



public void SetEndereço(string endereço)
{
    this.endereço= endereço;
}
public string GetEndereço()
{
    return endereço;
}
public void SetCpf(string cpf)
{
    this.cpf= cpf;
}
public string GetCpf()
{
    return cpf;
}

public void SetNumero(int Numero)
{
    this.Numero= Numero;
}
public int GetNumero()
{
    return Numero;
}



}