using System;
using Microsoft.EntityFrameworkCore;
using taz_hikes.api.Models;

namespace taz_hikes.api.Data
{
	public class TazHikesDbContext : DbContext
	{
		public TazHikesDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
		{
		}

		public DbSet<Difficulty> Difficulties { get; set; }
		public DbSet<Region> Regions { get; set; }
		public DbSet<Hike> Hikes { get; set; }
	}	
}

