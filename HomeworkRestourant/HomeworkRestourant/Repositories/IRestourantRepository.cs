using HomeworkRestourant.DataAccess.Entities;

namespace HomeworkRestourant.Repositories;

public interface IRestourantRepository
{
    void DeleteRestourant (Guid id);
    Restousant GetRestourantById (Guid id);
    List<Restousant> ReadRestourants();
    void UpdateRestourant (Restousant restourant);
    Guid WriteRestourant (Restousant restousant);
}