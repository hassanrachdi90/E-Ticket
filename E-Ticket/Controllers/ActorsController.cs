﻿using E_Ticket.Data;
using E_Ticket.Data.Services;
using E_Ticket.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticket.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        //Get:Actors\Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL, FullName,Bio")]Actor actor)
        {
            if(!ModelState.IsValid)
            {
               await _service.AddAsync(actor);
                return RedirectToAction(nameof(Index));
            }
            return View(actor);
        }
        //Get:Actors/Details/1
        public async Task<IActionResult>Details(int id)
        {
            var actorDetails=await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        //Get:Actors\Edit
        public  async Task<IActionResult> Edit(int id)
        {
			var actorDetails = await _service.GetByIdAsync(id);
			if (actorDetails == null)
			{
				return NotFound();
			}
			return View(actorDetails);
		}
        [HttpPost]
        public async Task<IActionResult> Edit(int id ,[Bind("Id,ProfilePictureURL, FullName,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                await _service.UpdateAsync(id,actor);
                return RedirectToAction(nameof(Index));
            }
            return View(actor);
        }
        //Get:Actors\Delete
        public async Task<IActionResult> Delete(int id)
        {
			var actorDetails = await _service.GetByIdAsync(id);
			if (actorDetails == null)
			{
				return NotFound();
			}
			return View(actorDetails);
		}
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
            {
                return NotFound();
            }

            await _service.DeleteAsync(id); 
            return RedirectToAction(nameof(Index));
            //var actorDetails = await _service.GetByIdAsync(id);
            //if (actorDetails == null) return View("NotFound");
            //await _service.DeleteAsync(id);
            //return RedirectToAction(nameof(Index));

        }
    }
}
