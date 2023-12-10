using DomainLayer.Enums;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DTO.DoctorDTO
{
    public class AppointmentDayDTO
    {
        public DaysEnum Day  { get; set; }
        List<Time> DocTime { get; set; }

        

    }
}
