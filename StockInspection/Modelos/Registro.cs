namespace StockInspection.Modelos;
public class Registro
{
    string nome;
    int Id;

public void SetNome(string nome)
{
    this.nome = nome;
}
public string GetNome()
{
    return nome;
}
public void SetId(int Id)
{
    this.Id = Id;
}
public int GetId()
{
    return Id;
}
}