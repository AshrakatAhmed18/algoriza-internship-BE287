using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository.PatientRepository.PatientBookingRepository
{
    public class PatientBookingRepository : IPatientBookingRepository
    {
        private readonly ApplicationDbContext _context;

        public PatientBookingRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Booking> GetAllPatientBookings()
        {
      

            var patientBookings = _context.Bookings.ToList(); 

            return patientBookings;
        }

        public bool CancelBooking(int bookingId)
        {
            // Logic to cancel a booking based on the provided bookingId
            // Use your data access mechanism to update the status of the booking to canceled
            // Return true if cancellation was successful, false otherwise

            // Example: Updating the status to canceled
            var bookingToCancel = _context.Bookings.FirstOrDefault(b => b.Id == bookingId);
            if (bookingToCancel != null)
            {
                bookingToCancel.RequestStatus.Id = bookingId;
                _context.SaveChanges();
                return true;
            }
            return false; 
        }

    }
}
