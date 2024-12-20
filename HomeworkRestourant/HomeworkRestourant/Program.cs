using HomeworkRestourant.Services;
using HomeworkRestourant.Services.DTOs;
using System.ComponentModel;

namespace HomeworkRestourant;

internal class Program
{
    static void Main(string[] args)
    {
        var resturantsService = new RetourantService();
        var restourant = new RestourantCreatDto()
        {
            Name = "Assorti",
            Email = "Assorti@gamil.com",
            ContactNumber = "12412412",
            IsOpen = (Services.Enums.IsOpenDto)1,
            Reyting = -1,
            CuisineType = "turk",


        };
        resturantsService.AddRestourant(restourant);
        
        
    }
}
