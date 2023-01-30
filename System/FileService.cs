using Newtonsoft.Json;
using System.Text.Json.Nodes;
namespace jepproject.System;

internal class FileService

{

    public void Save(string Path, string content)
    {

        using var sw = new StreamWriter(Path);
        sw.WriteLine(content);
    }


    public string Read(string Path)
    {

        try
        {
            using var sr = new StreamReader(Path);

            return sr.ReadToEnd();
        }

        catch
        {
            return null!;
        }
    }
}
