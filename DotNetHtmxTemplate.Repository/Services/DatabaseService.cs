﻿using DotNetHtmxTemplate.Repository.Data;
using DotNetHtmxTemplate.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetHtmxTemplate.Repository.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly AppDbContext _appDbContext;

        public DatabaseService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<(List<MovieModel> hits, int totalHits)> GetMovies(int pageSize, int startFrom) 
        {
            var movies = await _appDbContext.Movies.AsQueryable()
                .Skip(startFrom)
                .Take(pageSize)
                .ToListAsync();
            var count = await _appDbContext.Movies.AsQueryable()
                .CountAsync();
            return (movies, count);
        }
    }
}
