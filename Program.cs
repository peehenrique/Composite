using Composite;

var myFolder = new ArchiveComposite("My Folder /");
var myVideo = new ArchiveVideo("My_video.avi");
var myOtherVideo = new ArchiveVideo("series-netflix.mp4");

try
{
    myVideo.Add(myOtherVideo);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    myFolder.Add(myVideo);
    myFolder.Add(myOtherVideo);
    myFolder.PrintNameArchive();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    Console.WriteLine("\n Pesquisando Arquivos: ");

    myFolder.GetArchive(myVideo.GetNameArchive()).PrintNameArchive();

    Console.WriteLine("\n Remover arquivos: ");

    myFolder.Remove(myVideo.GetNameArchive());

    myFolder.PrintNameArchive();
}
catch (Exception e)
{
   Console.WriteLine(e.StackTrace);
}