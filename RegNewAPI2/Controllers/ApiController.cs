using Microsoft.AspNetCore.Mvc;
using RegNewAPI2.Models;
using Microsoft.EntityFrameworkCore;
using RegNewAPI2.Repository;


namespace RegNewAPI2.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ApiController : Controller

    {
        private IFisrtRepository FirstRepo;

        public ApiController(IFisrtRepository _FirstRepo)
        {
            FirstRepo = _FirstRepo;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var a = FirstRepo.Get();
            return Ok(a);
        }
        [HttpPost]
        public IActionResult Create(ApiModel mac)
        {
            var a = FirstRepo.Create(mac);
            return Ok(a);
        }
        [HttpGet("{id}")]
        public IActionResult Edit(int id)
        {
            var a = FirstRepo.Edit(id);
            return Ok(a);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            FirstRepo.Delete(id);
            return Ok();
        }
    }
}
