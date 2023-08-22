﻿using basiBuildAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace basiBuildAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }

        public DbSet<ToDo> ToDos => Set<ToDo>();
    }
}
