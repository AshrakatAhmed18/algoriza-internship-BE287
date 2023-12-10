using DomainLayer.DTO.DoctorDTO;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository.DoctorRepository.SettingRepository
{
    public class DoctorSettingService : IDoctorSettingService
        
    {
        private readonly IDoctorSettingRepository _doctorSettingRepository ;

        public DoctorSettingService(IDoctorSettingRepository adminSettingRepository)
        {
            _doctorSettingRepository = adminSettingRepository;
            
        }

        //public bool Add(AddAppointmentDTO NewModel)
        //{
        //    var AppointmentInDb = _doctorSettingRepository.Add(NewModel);

        //    AppointmentInDb.Appointment.DoctorDetails.Price = NewModel.Price;
        //    AppointmentInDb.Appointment.DaysId = NewModel.AppointmentDays;







            //}
        }
}
