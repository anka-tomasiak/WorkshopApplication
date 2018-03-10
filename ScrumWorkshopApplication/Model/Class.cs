using System.Data.Linq.Mapping;

namespace ScrumWorkshopApplication.Model
{
  [Table(Name = "Classes")]
  public class Class
  {
    [Column(Name = "Id", IsPrimaryKey = true, IsDbGenerated = true)]
    public int ID { get; set; }
    [Column]
    public string Name { get; set; }
    [Column(Name = "AddInfo")]
    public string Popularity { get; set; }
  }
}
