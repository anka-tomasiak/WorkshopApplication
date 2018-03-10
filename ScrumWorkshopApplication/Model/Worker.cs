using System.Data.Linq.Mapping;

namespace ScrumWorkshopApplication.Model
{
  [Table(Name = "Employees")]
  public class Worker
  {
    [Column(Name = "Id", IsPrimaryKey = true, IsDbGenerated = true)]
    public int ID { get; set; }
    [Column]
    public string Name { get; set; }
    [Column]
    public string Surname { get; set; }
  }
}
