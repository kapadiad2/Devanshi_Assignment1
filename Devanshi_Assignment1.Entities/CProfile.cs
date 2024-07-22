using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using AutoMapper;
namespace Devanshi_Assignment1.Entities
{
    public class CProfile : Profile
    {
        public CProfile()
        {
            CreateMap<customersss, CustomerDt>().ReverseMap();
        }
    
    }
}
