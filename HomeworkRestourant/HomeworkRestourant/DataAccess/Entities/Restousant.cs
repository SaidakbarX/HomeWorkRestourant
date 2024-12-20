using HomeworkRestourant.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkRestourant.DataAccess.Entities;

public class Restousant
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double Reyting { get; set; }
    public string Email { get; set; }
    public string ContactNumber { get; set; }
    public string CuisineType { get; set; }
    public  List<string> Menyu {  get; set; }   
    public IsDeliveryAvailable isDeliveryAvailable { get; set; }
    public IsOpen IsOpen { get; set; }
}
