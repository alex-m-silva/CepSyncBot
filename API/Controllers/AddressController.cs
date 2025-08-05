using Domain.Iterfaces.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : Controller
    {
        private readonly IAddressService _service;

        public AddressController(IAddressService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("list")]
        public async Task<IActionResult> AddAsync(List<AddressModel> addressModels)
        {
            await _service.AddAsync(addressModels);
            return Ok(new { Message = "Ceps cadastrados com sucesso!"});
        }

        [HttpPut]
        [Route("updateData")]
        public async Task<IActionResult> UpdateAsync(AddressModel addressModels)
        {
            await _service.UpdateDataAsync(addressModels);
            return Ok(new { Message = "Ceps atualizados com sucesso!" });
        }

        [HttpGet]
        [Route("getZipCode")]
        public async Task<IActionResult> GetZipCodeAsync(string robot)
        {
            var cep = await _service.GetZipCodeAsync(robot);
            return Ok(cep);
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            var ceps = await _service.GetAllAsync();
            return Ok(ceps);
        }
    }
}
