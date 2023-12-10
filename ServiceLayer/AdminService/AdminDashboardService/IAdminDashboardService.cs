using DomainLayer.DTO.AdminDTO.DashboardDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.AdminService.DashboardService
{
    public interface IAdminDashboardService
    {
        int NumOfDoctors();
        int NumOfPatients();
        NumOfRequestsDTO NumOfRequests();
        //List<TopFiveSpecializationsDTO> TopFiveSpecializations();

    }
}
