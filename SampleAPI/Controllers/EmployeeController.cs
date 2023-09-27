using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleAPI.Models;
using SampleAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IGenericService<EmployeeModel> _genericService = null;
        public EmployeeController(IGenericService<EmployeeModel> genericService)
        {
            _genericService = genericService;
        }
        [HttpPost]
        [Route("save")]
        public async Task<IActionResult> save([FromBody] EmployeeModel model)
        {

            _genericService.Insert(model);
            return Ok();
        }
        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> get()
        {
            return Ok(_genericService.GetAll());
        }
        [HttpGet]
        [Route("get/{id}")]
        public async Task<IActionResult> get(int id)
        {
            return Ok(_genericService.Get(id));
        }
    }
}
