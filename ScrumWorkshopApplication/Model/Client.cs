using System.Data.Linq.Mapping;

namespace ScrumWorkshopApplication.Model
{
  [Table(Name = "Clients")]
  public class Client
  {
    [Column(Name = "Id", IsPrimaryKey = true, IsDbGenerated = true)]
    public int ID { get; set; }
    [Column]
    public string Name { get; set; }
    [Column]
    public string Surname { get; set; }
    [Column]
    public string Address { get; set; }
  }
}
