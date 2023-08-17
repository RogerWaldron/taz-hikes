using System;
using Microsoft.EntityFrameworkCore;
using TazHikes.api.Models;

namespace TazHikes.api.Data
{
	public class TazHikesDbContext : DbContext
	{
		public TazHikesDbContext(DbContextOptions<TazHikesDbContext> dbContextOptions): base(dbContextOptions)
		{
		}

		public DbSet<Difficulty> Difficulties { get; set; }
		public DbSet<Region> Regions { get; set; }
		public DbSet<Hike> Hikes { get; set; }
	}	
}

