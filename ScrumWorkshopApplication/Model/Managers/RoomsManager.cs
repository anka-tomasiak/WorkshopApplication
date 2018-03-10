using System.Collections.Generic;
using System.Linq;
using ScrumWorkshopApplication.Model.Database;

namespace ScrumWorkshopApplication.Model.Managers
{
  public class RoomsManager
  {
    public List<Room> GetRooms()
    {
      var _rooms = new List<Room>();
      using (var dataContext = new MotoFitAcademyDataContext(Confiuration.GetSqlConnectionString()))
      {
        _rooms = dataContext.Rooms.ToList();
      }
      return _rooms;
    }
    public void AddRoom(Room room)
    {
      using (var dataContext = new MotoFitAcademyDataContext(Confiuration.GetSqlConnectionString()))
      {
        dataContext.Rooms.InsertOnSubmit(room);
        dataContext.SubmitChanges();
      }
    }
    public void EditRoom(Room room)
    {
      using (var dataContext = new MotoFitAcademyDataContext(Confiuration.GetSqlConnectionString()))
      {
        var roomToEdit = dataContext.Rooms.FirstOrDefault(r => r.ID == room.ID);
        roomToEdit.Name = room.Name;
        roomToEdit.Capacity = room.Capacity;
        dataContext.SubmitChanges();
      }
    }
  }
}
