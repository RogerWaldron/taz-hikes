using System;
namespace taz_hikes.api.Models
{
	public class Hike
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public double DistanceInKm { get; set; }
		public string? HikeImgUrl { get; set; }

		// Foreign Keys
		public Guid DifficultyId { get; set; }
		public Guid RegionId { get; set; }

		public Difficulty Difficulty { get; set; }
		public Region Region { get; set; }
	}
}

