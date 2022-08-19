using Microsoft.EntityFrameworkCore;
using System;

namespace ParksLookup.Models
{
  public class ParksLookupContext : DbContext
  {
    public ParksLookupContext(DbContextOptions<ParksLookupContext> options)
    : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {

      builder.Entity<Park>()
        .HasData(
          new Park {	CreatedDate = DateTime.Now,	 ParkId  = 1,	ParkCode =  "zion", Title  = "Zion National Park",	 Description  = "Follow the paths where native people and pioneers walked. Gaze up at massive sandstone cliffs of cream, pink, and red that soar into a brilliant blue sky. Experience wilderness in a narrow slot canyon. Zion’s unique array of plants and animals will enchant you as you absorb the rich history of the past and enjoy the excitement of present day adventures.",	 State  = "UT",	 City  = "Springdale",	Lat = 37.29839254,	Lng = -113.0265138,	 Zipcode  = "84767"	},
          new Park {	CreatedDate = DateTime.Now,	 ParkId  = 2,	ParkCode =  "acad", Title  = "Acadia National Park",	 Description  = "Acadia National Park protects the natural beauty of the highest rocky headlands along the Atlantic coastline of the United States, an abundance of habitats, and a rich cultural heritage. At 4 million visits a year, it's one of the top 10 most-visited national parks in the United States. Visitors enjoy 27 miles of historic motor roads, 158 miles of hiking trails, and 45 miles of carriage roads.",	 State  = "ME",	 City  = "Bar Harbor",	Lat = 44.409286,	Lng = -68.247501,	 Zipcode  = "04609"	},
          new Park {	CreatedDate = DateTime.Now,	 ParkId  = 3,	ParkCode =  "crla", Title  = "Crater Lake National Park",	 Description  = "Crater Lake inspires awe. Native Americans witnessed its formation 7,700 years ago, when a violent eruption triggered the collapse of a tall peak. Scientists marvel at its purity—fed by rain and snow, it’s the deepest lake in the USA and one of the most pristine on Earth. Artists, photographers, and sightseers gaze in wonder at its blue water and stunning setting atop the Cascade Mountain Range.",	 State  = "OR",	 City  = "Crater Lake",	Lat = 42.94065854,	Lng = -122.1338414,	 Zipcode  = "97604"	}
        );
    }
    public DbSet<Park> Parks { get; set; }
  }
}