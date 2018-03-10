using System.Collections.Generic;
using System.Linq;
using ScrumWorkshopApplication.Model.Database;

namespace ScrumWorkshopApplication.Model.Managers
{
  public class ClassesManager
  {
    public List<Class> GetClasses()
    {
      var _classes = new List<Class>();
      using (var dataContext = new MotoFitAcademyDataContext(Confiuration.GetSqlConnectionString()))
      {
        _classes = dataContext.Classes.ToList();
      }
      return _classes;
    }
    public void AddClass(Class _class)
    {
      using (var dataContext = new MotoFitAcademyDataContext(Confiuration.GetSqlConnectionString()))
      {
        dataContext.Classes.InsertOnSubmit(_class);
        dataContext.SubmitChanges();
      }
    }
    public void DeleteClass(Class _class)
    {
      using (var dataContext = new MotoFitAcademyDataContext(Confiuration.GetSqlConnectionString()))
      {
        dataContext.Classes.Attach(_class);
        dataContext.Classes.DeleteOnSubmit(_class);
        dataContext.SubmitChanges();
      }
    }
    public void EditClass(Class _class)
    {
      using (var dataContext = new MotoFitAcademyDataContext(Confiuration.GetSqlConnectionString()))
      {
        var classToEdit = dataContext.Classes.FirstOrDefault(c => c.ID == _class.ID);
        classToEdit.Name = _class.Name;
        classToEdit.Popularity = _class.Popularity;
        dataContext.SubmitChanges();
      }
    }
  }
}
