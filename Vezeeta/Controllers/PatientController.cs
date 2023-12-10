using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.PatientService.PatientBookingService;
using ServiceLayer.PatientService.PatientDoctorService;

namespace Vezeeta.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    { 
        private readonly PatientDoctorService _patientDoctorService;
        private readonly PatientBookingService _patientBookingService;

        public PatientController(PatientDoctorService patientDoctorService ,
                                 PatientBookingService patientBookingService)
        {
            _patientDoctorService = patientDoctorService;
            _patientBookingService = patientBookingService;
        }
        [HttpGet("search")]
        public IActionResult SearchDoctors(int page = 1, int pageSize = 5, string search = "")
        {
            var doctors = _patientDoctorService.SearchDoctors(page, pageSize, search);
            return Ok(doctors);
        }

        [HttpGet("bookings")]
        public IActionResult GetPatientBookings()
        {
            var patientBookings = _patientBookingService.GetAllPatientBookings();
            return Ok(patientBookings);
        }

        [HttpDelete("cancel")]
        public IActionResult CancelBooking(int bookingId)
        {
            var isCanceled = _patientBookingService.CancelBooking(bookingId);
            if (isCanceled)
            {
                return Ok(true); // Booking was successfully canceled
            }
            return NotFound("This Booking is not found"); // Booking with ID not found 
        }

        [HttpGet("booking")]
        public IActionResult BookAppointment(int doctorId,Booking bookingRequest)
        {
            var isBooked = _patientDoctorService.BookAppointment(doctorId, bookingRequest);
            if (isBooked)
            {
                return Ok(true); // Appointment was successfully booked
            }
            return NotFound(); // Doctor or time slot not found or booking failed
        }

    }

}
