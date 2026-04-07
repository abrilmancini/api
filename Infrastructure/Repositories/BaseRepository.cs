using System;

namespace Infrastructure.Repositories;

public abstract class BaseRepository<T> where T : class
{
    protected readonly BookChampionContext _context;
    
    public BaseRepository(BookChampionContext context)
    {
        _context = context;
    }

    public List<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }
}