using HomeworkRestourant.Services.Enums;

namespace HomeworkRestourant.Services.DTOs;

public class RestourantCreatDto
{
    public string Name { get; set; }
    public double Reyting { get; set; }
    public string Email { get; set; }
    public string ContactNumber { get; set; }
    public string CuisineType { get; set; }
    public List<string> Menyu { get; set; }


    public IsDeliveryAvailableDto isDeliveryAvailable { get; set; }
    public IsOpenDto IsOpen { get; set; }
}
