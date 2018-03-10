using System.Data.Linq;

namespace ScrumWorkshopApplication.Model.Database
{
  public class MotoFitAcademyDataContext : DataContext
  {
    public MotoFitAcademyDataContext(string connectionString)
        : base(connectionString)
    { }

    public Table<Worker> Workers;
    public Table<Class> Classes;
    public Table<Client> Clients;
    public Table<Room> Rooms;
    public Table<WorkPlanElement> WorkPlanElements;
  }
}
