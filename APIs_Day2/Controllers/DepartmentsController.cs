using APIs_Day2_BL.Dtos;
using APIs_Day2_BL.Services;
using Microsoft.AspNetCore.Mvc;

namespace APIs_Day2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentService departmentService;
        public DepartmentsController(IDepartmentService departmentService) { 
            this.departmentService = departmentService;
        }

        [HttpGet]
        [Route("id")]
        public ActionResult<DepartmentDto> GetById(int id)
        {
            if(id <= 0 || departmentService.GetDepartmentDetailsWithTicketsById(id) == null)            
                return NotFound();
            
            return Ok(departmentService.GetDepartmentDetailsWithTicketsById(id));
        }
    }
}
