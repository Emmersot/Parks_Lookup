using System.ComponentModel.DataAnnotations;
using System;

namespace ParksLookup.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public DateTime CreatedDate { get; set; }
    [Required]
    public string City { get; set; }
    public string State { get; set; } 
    public string Zipcode { get; set; }
    public double Lat { get; set; }
    public double Lng { get; set; }
    public string ParkCode { get; set; }
  }
}