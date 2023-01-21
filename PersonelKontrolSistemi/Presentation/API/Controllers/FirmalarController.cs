using Application.Abstractions;
using Application.Repositories;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmalarController : ControllerBase
    {
        readonly private IFirmaReadRepository _firmaReadRepository;
        readonly private IFirmaWriteRepository _firmaWriteRepository;

        public FirmalarController(IFirmaReadRepository firmaReadRepository, IFirmaWriteRepository firmaWriteRepository)
        {
            _firmaReadRepository = firmaReadRepository;
            _firmaWriteRepository = firmaWriteRepository;
        }
        [HttpGet]
        public async Task Get()
        {
            //await _firmaWriteRepository.AddRangeAsync(new()
            // {
            //     new(){SubeId=1,PersonelId=1,PersonelHareketleriId=1,FirmaAdi="Benim Firma"},
            //     new(){SubeId=2,PersonelId=2,PersonelHareketleriId=2,FirmaAdi="Senin Firma"},
            //     new(){SubeId=3,PersonelId=3,PersonelHareketleriId=3,FirmaAdi="Onun Firma"}

            // });
            // await _firmaWriteRepository.SaveAsync();

            //Firma f = await _firmaReadRepository.GetByIdAsync(1,false); Tracking denedik
            //f.FirmaAdi = "Merve";
            //await _firmaWriteRepository.SaveAsync();
               
        }
        [HttpGet ("{id}")]
        public async Task<IActionResult>Get(int id)
        {
            Firma firma = await _firmaReadRepository.GetByIdAsync(id);
            return Ok(firma);
        }

       

    }
}
