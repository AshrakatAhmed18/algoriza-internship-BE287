using DomainLayer.Models;
using RepositoryLayer.Repository.PatientRepository.PatientDoctorRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.PatientService.PatientDoctorService
{
    public class PatientDoctorService
    {
        private readonly IPatientDoctorRepository _patientdoctorRepository;

        public PatientDoctorService(IPatientDoctorRepository patientdoctorRepository)
        {
            _patientdoctorRepository = patientdoctorRepository;
        }

        public IEnumerable<DoctorDetails> SearchDoctors(int page, int pageSize, string search)
        {
            return _patientdoctorRepository.GetAllDoctors(page, pageSize, search);
        }

        public bool BookAppointment(int doctorId, Booking bookingRequest)
        {
            return _patientdoctorRepository.BookAppointment(doctorId, bookingRequest);
        }
    }
}
