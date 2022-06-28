namespace Composite;

public abstract class ArchiveComponent
{
    protected string _nameArchive;

    public virtual void PrintNameArchive()
    {
        Console.WriteLine(this._nameArchive);
    }

    public virtual string GetNameArchive()
    {
        return _nameArchive;
    }

    public virtual void Add(ArchiveComponent nameArchive)
    {
        throw new Exception($"Náo é possível inserir arquivos em: {_nameArchive} - Nao é uma pasta");
    }

    public virtual void Remove(string nameArchive)
    {
        throw new Exception($"Nao pode remover arquivos em {_nameArchive} - Nao é uma pasta");
    }

    public virtual ArchiveComponent GetArchive(string nameArchive)
    {
        throw new Exception($"Nao pode pesquisar arquivos em {_nameArchive} - Nao é uma pasta");
    }
}