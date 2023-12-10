using DomainLayer.DTO.AdminDTO.PatientDTO;
using DomainLayer.DTO.AdminDTO.DoctorDTO;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository.AdminRepository.PatientRepository
{
    public interface IAdminPatientRepository
    {

       

        List<GetAllPatientDTO> GetPatientDetails();

        Booking GetPatientById(int id);


      

    }
}
