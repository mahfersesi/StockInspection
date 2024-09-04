using StockInspection.Controles;

namespace StockInspection.Controles;

public class EstadoControle : PaiControle
{
  //----------------------------------------------------------------------------

  public EstadoControle() : base()
  {
    NomeDaTabela = "Estados";
  }

  //----------------------------------------------------------------------------

  public virtual Modelos.Registro? Ler(int idEstado)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idEstado);
  }

  //----------------------------------------------------------------------------

  public virtual List<EstadoControle>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Estado>(NomeDaTabela);
    return new List<Estado>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idEstado)
  {
    var collection = liteDB.GetCollection<Estado>(NomeDaTabela);
    collection.Delete(idEstado);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(EstadoControle estado)
  {
    var collection = liteDB.GetCollection<Estado>(NomeDaTabela);
    collection.Upsert(estado);
  }

  //----------------------------------------------------------------------------
}