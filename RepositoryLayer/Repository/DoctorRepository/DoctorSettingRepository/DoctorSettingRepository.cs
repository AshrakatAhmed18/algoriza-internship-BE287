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
    public class DoctorSettingRepository : IDoctorSettingRepository

    {
        private readonly ApplicationDbContext _Context;

        public DoctorSettingRepository(ApplicationDbContext Context)
        {
            _Context = Context;
        }
        public Time Add(AddAppointmentDTO NewModel)
        {

            var Model = _Context.Times
                                   .Include(Appo => Appo.Appointment)
                                   .ThenInclude(Doc => Doc.DoctorDetails)
                                   .Include(Appo => Appo.Appointment)
                                   .ThenInclude(day => day.Days);
            if (NewModel != null)
            {
                _Context.Add(NewModel);
                _Context.SaveChanges();
                return (Time)Model;

            }
            else
            {
                return (Time) Model;
            }


        }
    }
}
