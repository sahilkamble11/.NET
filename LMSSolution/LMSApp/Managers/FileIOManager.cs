
using System.IO.Enumeration;
using System.Text;
using System.Text.Json;

using LMSApp.Entities;
namespace LMSApp.Managers;


public sealed  class FileIOManager
{
    public string fileName="../data.json";
    private static FileIOManager _mgr; 
    private FileIOManager()
    {
       
    }

    public FileIOManager GetInstance()
    {
        if(_mgr == null)
        {
            _mgr=new FileIOManager();
        }
        return _mgr;
    }
    public  bool Serialize(string data, List<Person> people)
    {
        bool status =false;
        string jsonPeople= JsonSerializer.Serialize<List<Person>>(people );
        File.WriteAllText(data, jsonPeople);
        status=true;
        return status;
    }

    public  List<Person> Deserialize(string data)
    {
        string jsonPeople=File.ReadAllText(data);
        List<Person> allMembers=JsonSerializer.Deserialize<List<Person>> (jsonPeople);
        return allMembers;
    }
}