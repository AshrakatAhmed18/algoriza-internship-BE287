using DomainLayer.Models;
using RepositoryLayer.Repository.PatientRepository.PatientBookingRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.PatientService.PatientBookingService
{
    public class PatientBookingService
    {
        private readonly IPatientBookingRepository _patientBookingRepository;

        public PatientBookingService(IPatientBookingRepository patientBookingRepository)
        {
            _patientBookingRepository = patientBookingRepository;
        }

        public IEnumerable<Booking> GetAllPatientBookings()
        {
            return _patientBookingRepository.GetAllPatientBookings();
        }

        public bool CancelBooking(int bookingId)
        {
            return _patientBookingRepository.CancelBooking(bookingId);
        }
    }
}
