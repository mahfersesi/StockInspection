namespace StockInspection.Modelos;
public class Cliente
{
    string nome;
    int id;
    string cpf;
    int numero;
    string endereço;

public void SetNome(string nome)
{
    this.nome = nome;
}
public string GetNome()
{
    return nome;
}

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

public void SetNumero(int numero)
{
    this.numero= numero;
}
public int GetNumero()
{
    return numero;
}



}