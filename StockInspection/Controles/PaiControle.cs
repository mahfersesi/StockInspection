namespace StockInspection.Controles;

public class PaiControle
{
  protected string NomeDaTabela;
  protected static LiteDatabase liteDB = null;

  public PaiControle()
  {
    var pathToPersonalFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SESI.db");

    if (liteDB == null)
      liteDB = new LiteDatabase(@"filename=" + pathToPersonalFolder + "; upgrade=true; Mode=Exclusive");
  }
    public virtual void CriarOuAtualizar(Modelos.Registro r)
  {

  }
   public virtual void Apagar(int id)
  {

  }
  public virtual Modelos.Registro? Ler(int id)
  {
    return null;
  }
    public virtual List<Modelos.Registro>? LerTodos()
  {
    return null;
  }



}