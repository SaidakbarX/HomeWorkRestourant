using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkRestourant.Services.DTOs;

public class RestourantDto : RestourantCreatDto
{
    public Guid Id { get; set; }
}
