﻿using E_Ticket.Models;

namespace E_Ticket.Data.Services
{
    public interface IActorsService
           {
             Task<IEnumerable<Actor>> GetAllAsync();
             Task <Actor> GetByIdAsync(int id);
             Task AddAsync(Actor actor);
             Task <Actor> UpdateAsync(int id, Actor newActor);
             Task DeleteAsync(int id);

           }
}
