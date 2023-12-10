using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository.PatientRepository.PatientBookingRepository
{
    public interface IPatientBookingRepository
    {
        IEnumerable<Booking> GetAllPatientBookings();
        bool CancelBooking(int bookingId);
    }
}
