using System.Data.Linq.Mapping;

namespace ScrumWorkshopApplication.Model
{
  [Table(Name = "Rooms")]
  public class Room
  {
    [Column(Name = "Id", IsPrimaryKey = true, IsDbGenerated = true)]
    public int ID { get; set; }
    [Column]
    public string Name { get; set; }
    [Column]
    public int Capacity { get; set; }
  }
}
