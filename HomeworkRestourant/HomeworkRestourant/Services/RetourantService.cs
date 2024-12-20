using HomeworkRestourant.DataAccess.Entities;
using HomeworkRestourant.Repositories;
using HomeworkRestourant.Services.DTOs;

namespace HomeworkRestourant.Services;

public class RetourantService : IRetourantService
{
    private readonly IRestourantRepository _restourantRepository;
    public RetourantService()
    {
        _restourantRepository = new RestourantRepository();

    }
    public Guid AddRestourant(RestourantCreatDto dto)
    {
        var entity = ConvertToRestourant(dto);
        var id = _restourantRepository.WriteRestourant(entity);
        return id;


    }

    public void DeleteRestourant(Guid id)
    {
       var delete = GetRestourantById(id);
        var entity = ConvertToRestourant(delete);
        _restourantRepository.DeleteRestourant(entity.Id);
    }

    public List<RestourantDto> GetAllRestourants()
    {
        var restourants =_restourantRepository.ReadRestourants();
        var newrestourants = new List<RestourantDto>();
        foreach (var restourant in restourants)
        {
            newrestourants.Add(ConvertToDto(restourant));
        }
        return newrestourants;
    }

    public RestourantDto GetRestourantById(Guid id)
    {
       var dto = _restourantRepository.GetRestourantById(id);
        return ConvertToDto(dto);
    }

    public void UpdateRestourant(RestourantDto dto)
    {
        var updateRestourant = GetRestourantById(dto.Id);
        var entity  =  ConvertToRestourant(updateRestourant);
        _restourantRepository.UpdateRestourant(entity);
    }
    private Restousant ConvertToRestourant(RestourantCreatDto dto)
    {
        return new Restousant
        {
            Id = Guid.NewGuid(),
            Name = dto.Name,
            ContactNumber = dto.ContactNumber,
            CuisineType = dto.CuisineType,
            Email = dto.Email,
            Reyting = dto.Reyting,
            isDeliveryAvailable = (DataAccess.Enums.IsDeliveryAvailable)dto.isDeliveryAvailable,
            IsOpen = (DataAccess.Enums.IsOpen)dto.IsOpen,
            Menyu = dto.Menyu,



        };
    }
    private Restousant ConvertToRestourant(RestourantDto dto)
    {
        return new Restousant
        {
            Id = dto.Id,
            Name = dto.Name,
            ContactNumber = dto.ContactNumber,
            Email = dto.Email,
            Reyting = dto.Reyting,
            CuisineType = dto.CuisineType,
            isDeliveryAvailable = (DataAccess.Enums.IsDeliveryAvailable)dto.isDeliveryAvailable,
            IsOpen = (DataAccess.Enums.IsOpen)dto.IsOpen,
            Menyu = dto.Menyu,


        };
    }
    private RestourantDto ConvertToDto(Restousant restousant)
    {
        return new RestourantDto
        {  
            Id =restousant.Id,
            Name = restousant.Name,
            ContactNumber = restousant.ContactNumber,
            Email = restousant.Email,
            CuisineType=restousant.CuisineType,
            Menyu=restousant.Menyu,
            Reyting=restousant.Reyting, 
            isDeliveryAvailable = (Enums.IsDeliveryAvailableDto)restousant.isDeliveryAvailable,
            IsOpen = (Enums.IsOpenDto)restousant.IsOpen,

        };
    }
}
