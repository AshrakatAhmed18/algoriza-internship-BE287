using DomainLayer.DTO.DoctorDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Repository.DoctorRepository.SettingRepository;

namespace Vezeeta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorSettingService _doctorSettingService;

        public DoctorController(IDoctorSettingService doctorSettingService)
        {
            _doctorSettingService = doctorSettingService;
        }
        //[HttpPost]
        //public IActionResult Add(AddAppointmentDTO NewModel)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        _doctorSettingService.Add(NewModel);
        //        return StatusCode(200, true);

        //    }
        //    else
        //    {
        //        return StatusCode(400, false);


        //    }


        //}

    }
}
