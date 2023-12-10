using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository.PatientRepository.PatientDoctorRepository
{
    public class PatientDoctorRepository : IPatientDoctorRepository
    {

        private readonly ApplicationDbContext _context;

        public PatientDoctorRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<DoctorDetails> GetAllDoctors(int page, int pageSize, string search)
        {
            var doctors = _context.DoctorDetails
              .Where(d => d.Equals(search))
              .Skip((page - 1) * pageSize)
              .Take(pageSize)
              .ToList();

            return doctors;
        }

        public bool BookAppointment(int doctorId, Booking bookingRequest)
        {
     
            var appointment = _context.DoctorDetails
                .FirstOrDefault(d => d.Id == doctorId)?
                .Appointments.FirstOrDefault(a => a.AppTimes.Any(t => t.Id == bookingRequest.TimetableID));

            if (appointment != null)
            {
        
                appointment.IsBooked = true;
                _context.SaveChanges(); 
                return true;
            }
            return false; 
        }
    }
}
