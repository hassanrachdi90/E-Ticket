using E_Ticket.Data;
using E_Ticket.Data.Services;
using E_Ticket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Ticket.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;
        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers =await _service.GetAllAsync();
            return View(allProducers);
        }
        //Get:Producer/Details/1
        public async Task<IActionResult> Details(int id )
        {
            var producersDetails=await _service.GetByIdAsync(id);
            if (producersDetails==null) return View("NotFound");
            return View(producersDetails);
        }
        //Get :Priducers/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")] Producer producer)
        {
            if(!ModelState.IsValid) return View(producer);
            
            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }
        //Get :Priducers/Edit
        public async Task <IActionResult> Edit(int id)
        {
            var producersDetails = await _service.GetByIdAsync(id);
            if (producersDetails == null) return View("NotFound");
            return View(producersDetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id ,[Bind("Id,ProfilePictureURL,FullName,Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);
            if (id == producer.Id)
            {
                await _service.UpdateAsync(id, producer);
                return RedirectToAction(nameof(Index));
            }
            return View(producer);
           
        }
    }
}
