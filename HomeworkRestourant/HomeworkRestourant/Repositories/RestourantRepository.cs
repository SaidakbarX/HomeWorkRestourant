using HomeworkRestourant.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HomeworkRestourant.Repositories;

public class RestourantRepository : IRestourantRepository
{
    private readonly string _path;
    private List<Restousant> _restourants;
    public RestourantRepository()
    {
        _path = "../../../DataAccess/Data/Restourant.json";
        _restourants = new List<Restousant>();
        if (!File.Exists(_path))
        {
            File.WriteAllText(_path, "[]");
        }
        _restourants = ReadRestourants();

    }
    public void DeleteRestourant(Guid id)
    {
        var deletRestourant = GetRestourantById(id);
        _restourants.Remove(deletRestourant);
        SaveDate();

    }

    public Restousant GetRestourantById(Guid id)
    {
        foreach(var  restourant in _restourants)
        {
            if (restourant.Id == id)
            {
                return restourant;
            }
        }
        throw new Exception("bunday idli restourant yoq");
    }

    public List<Restousant> ReadRestourants()
    {
       var restourantJson = File.ReadAllText(_path);
        var restourant = JsonSerializer.Deserialize<List<Restousant>>(restourantJson);
        return restourant;
    }

    public void UpdateRestourant(Restousant restourant)
    {
        var updateRestourant = GetRestourantById(restourant.Id);
        var index = _restourants.IndexOf(updateRestourant);
        _restourants[index] = restourant;
        SaveDate();

        
    }

    public Guid WriteRestourant(Restousant restousant)
    {
        _restourants.Add(restousant);
        SaveDate();
        return restousant.Id;
    }
    public void SaveDate()
    {
        var restourantJson = JsonSerializer.Serialize(_restourants);
        File.WriteAllText (_path, restourantJson);
    }
}
