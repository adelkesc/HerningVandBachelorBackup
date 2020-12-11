﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace BachelorApp.Data
{
    public class ReadingService : IReadingService
    {
        private readonly IDbContextFactory<DatabaseContext> _contextFactory;



        public ReadingService(IDbContextFactory<DatabaseContext> _db)
        {
            _contextFactory = _db;
        }

        public async Task<List<Reading>> DisplayReadings()
        {
            List<Reading> readings;
            using var context = _contextFactory.CreateDbContext();
            {
                readings = context.Readings.ToList();
            };
            
            return readings;
        }

        public async Task AddReading(Reading reading)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Readings.Add(reading);
            await context.SaveChangesAsync();
        }
    }
}
