namespace Composite;

public class ArchiveComposite : ArchiveComponent
{
    private List<ArchiveComponent> _archives = new List<ArchiveComponent>();

    public ArchiveComposite(string nameArchive)
    {
        _nameArchive = nameArchive;
    }

    public override void PrintNameArchive()
    {
        Console.WriteLine(_nameArchive);

        foreach (var archiveTemp in _archives)
        {
            archiveTemp.PrintNameArchive();
        }
    }

    public override void Add(ArchiveComponent nameArchive)
    {
        _archives.Add(nameArchive);
    }

    public override void Remove(string nameArchive)
    {
        foreach (var archiveTemp in _archives)
        {
            if (archiveTemp.GetNameArchive() == nameArchive)
            {
                _archives.Remove(archiveTemp);
            
                return;
            }
        }

        throw new Exception("Nao existe este arquivo");
    }

    public override ArchiveComponent GetArchive(string nameArchive)
    {
        foreach (var archiveTemp in _archives)
        {
            if (archiveTemp.GetNameArchive() == nameArchive)
            {
                return archiveTemp;
            }
        }
        
        throw new Exception("Nao existe este arquivo");
    }
}