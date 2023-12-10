using DomainLayer.DTO.AdminDTO.DoctorDTO;
using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.AdminService.DoctorServices
{
    public interface IAdminDoctorService
    {
 

        //----- Start (Get info about all doctors) --------//
        List<AllDoctorDetailsDTO> GetDoctorDetails();
        GetDoctorByIdDTO GetDoctorById(int id);
        bool CreateDoctor(CreateNewDoctorDTO NewModel);
        bool UpdateDoctor(UpdateDoctorDTO NewModel, int id);
        bool DeleteDoctor(int id);
        //----- End (Get info about all doctors) --------//


    }
}
