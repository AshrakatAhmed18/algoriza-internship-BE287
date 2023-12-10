using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository.PatientRepository.PatientDoctorRepository
{
    public interface IPatientDoctorRepository
    {
        IEnumerable<DoctorDetails> GetAllDoctors(int page, int pageSize, string search);

        bool BookAppointment(int doctorId, Booking bookingRequest);

    }
}
