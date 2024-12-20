using HomeworkRestourant.Services.DTOs;

namespace HomeworkRestourant.Services;

public interface IRetourantService
{
    void UpdateRestourant (RestourantDto dto);
    void DeleteRestourant (Guid id);
    List<RestourantDto> GetAllRestourants ();
    Guid AddRestourant (RestourantCreatDto dto);
    RestourantDto GetRestourantById (Guid id);
}