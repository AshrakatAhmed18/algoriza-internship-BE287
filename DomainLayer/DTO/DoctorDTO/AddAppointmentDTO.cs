using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DTO.DoctorDTO
{
    public class AddAppointmentDTO
    {
        public float Price { get; set; }

        public List<AppointmentDayDTO> AppointmentDays { get; set; }

        
    }
}
