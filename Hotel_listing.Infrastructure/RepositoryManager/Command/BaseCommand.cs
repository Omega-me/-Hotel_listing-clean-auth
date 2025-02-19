﻿using Hotel_listing.Application.Contracts.RepositoryManager.Command;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using DatabaseContext = Hotel_listing.Persistence.DatabaseContext;

namespace Hotel_listing.Infrastructure.RepositoryManager.Command;
public class BaseCommand<T>: IBaseCommand<T> where T:class
{
    private readonly DatabaseContext _context;
    private readonly DbSet<T> _db;

    public BaseCommand(DatabaseContext context)
    {
        _context = context;
        _db = _context.Set<T>();   
    }
    
    public async Task Insert(T entity) {
        await _db.AddAsync(entity);
    }

    public void Update(T entity) {
        _db.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
    }
    public void UpdatePartial(T entity,JsonPatchDocument data) {
        data.ApplyTo(entity);
        _context.Entry(entity).State = EntityState.Modified;
    }
    public async Task Delete(int id)
    {
        var entity =await _db.FindAsync(id);
        if (entity != null) _db.Remove(entity);
    }
}