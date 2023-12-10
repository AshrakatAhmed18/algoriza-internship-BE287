using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Time
    {
        public int Id { get; set; }

        [DataType(DataType.Time)]
        public DateTime TimeInHour { get; set; } = DateTime.Now;

        [ForeignKey("Appointment")]
        public int AppointmentID { get; set; }
        public Appointment Appointment { get; set; }


    }
}
